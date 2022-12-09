using Business.ConstClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Business.Util;
using Business.Enum;
using System.Reflection;

namespace Business.ConstClass
{
    public class ConstClassGenerator
    {
        /// <summary>
        /// 生成常量类
        /// </summary>
        /// <returns></returns>
        public static string Generate(ConstClassParamModel paraModel)
        {
            if (paraModel == null)
            {
                throw new ArgumentException("paramModel");
            }

            paraModel.Validation();
            Analysis(paraModel);

            var constFieldContent = paraModel.FieldModels
                .Select(p => string.Format(@"        /// <summary>
        /// {0}
        /// </summary>
        public const {1} {2}{3} = {4};", p.FieldSummary, paraModel.FieldType, paraModel.FieldPrefix, p.FieldName, p.FieldValue));

            var namesContent = paraModel.FieldModels
                .Select(p => string.Format(@"           {{ {0}{1}, {2} }}", paraModel.FieldPrefix, p.FieldName, $"\"{p.FieldSummary}\""));

            var result = new StringBuilder();
            result.Append(string.Format(@"    /// <summary>
    /// {0}
    /// </summary>
    public class {1}
    {{
{2}

        private static readonly Dictionary<{3}, string> _Names = new Dictionary<{3}, string>
        {{
{4}
        }};

        /// <summary>
        /// 常量列表
        /// </summary>
        /// <returns></returns>
        public static {3}[] GetAllKeys()
        {{
            return _Names.Keys.ToArray();
        }}

        /// <summary>
        /// 获取名称
        /// </summary>
        /// <returns></returns>
        public static string GetName({3} key)
        {{
            return _Names.ContainsKey(key) ? _Names[key] : string.Empty;
        }}

         /// <summary>
         /// 获取列表
         /// </summary>
         /// <returns></returns>
         public static List<KeyValuePair<{3}, string>> GetAllList()
         {{
             return _Names.ToList();
         }}
    }}", paraModel.ClassSummary, paraModel.ClassName, string.Join(Environment.NewLine, constFieldContent), paraModel.FieldType, string.Join("," + Environment.NewLine, namesContent)));

            return result.ToString();
        }

        /// <summary>
        /// 将输入字符串转为属性类列表
        /// </summary>
        /// <returns></returns>
        public static void Analysis(ConstClassParamModel paraModel)
        {
            paraModel.FieldModels = new List<ConstClassFieldModel>();

            var matchesX = Regex.Matches(paraModel.InputString, paraModel.RegexPattern)
                                .OfType<Match>()
                                .ToList();
            paraModel.GenerateFieldPattern = GetGenerateFieldPattern(matchesX);

            var matches = matchesX
                          .Select(p => new ConstClassFieldModel
                          {
                              FieldName = GetFieldMetadata(p, paraModel.GetFieldPatternProperty(y => y.FieldNamePattern)),
                              FieldValue = GetFieldMetadata(p, paraModel.GetFieldPatternProperty(y => y.FieldValuePattern)),
                              FieldSummary = GetFieldMetadata(p, paraModel.GetFieldPatternProperty(y => y.FieldSummaryPattern))
                          })
                          .ToList();

            if (matches.All(p => p.FieldValue.IsNumeric()))
            {
                paraModel.GenerateFieldPattern.GeneratedFieldType = PropertyType.Int;

                if (!string.IsNullOrEmpty(paraModel.ClassName))
                {
                    if (paraModel.ClassName.ToLower().Contains("type"))
                    {
                        paraModel.GenerateFieldPattern.FieldPrefix = CommonPrefix.T;
                    }
                    else if (paraModel.ClassName.ToLower().Contains("code"))
                    {
                        paraModel.GenerateFieldPattern.FieldPrefix = CommonPrefix.C;
                    }
                    else
                    {
                        paraModel.GenerateFieldPattern.FieldPrefix = CommonPrefix.O;
                    }
                }
            }
            else
            {
                paraModel.GenerateFieldPattern.GeneratedFieldType = PropertyType.String;
            }

            if (string.IsNullOrEmpty(paraModel.FieldType))
            {
                paraModel.GenerateFieldPattern.FieldType = paraModel.GeneratedFieldType;
            }
            if (paraModel.FieldType == PropertyType.String)
            {
                matches.ForEach(data => data.FieldValue = $"\"{data.FieldValue}\"");
            }

            paraModel.FieldModels.AddRange(matches);
        }

        private static FieldPattern GetGenerateFieldPattern(List<Match> matches)
        {
            var result = new FieldPattern();

            var count = matches.Max(p => p.Groups.Count);
            if (count == 3)
            {
                result.FieldNamePattern = "$1";
                result.FieldValuePattern = "$1";
                result.FieldSummaryPattern = "$2";
            }
            else if (count == 4)
            {
                result.FieldNamePattern = "$1";
                result.FieldValuePattern = "$2";
                result.FieldSummaryPattern = "$3";
            }

            return result;
        }

        private static string GetFieldMetadata(Match match,string pattern)
        {
            var result = pattern;

            Regex.Matches(pattern, @"(\$)(\d+)")
                 .OfType<Match>()
                 .Select(p => new
                 {
                     Node = p.Groups[1].ToString() + p.Groups[2].ToString(),
                     Index = int.Parse(p.Groups[2].ToString())
                 })
                 .ToList()
                 .ForEach(data => result = result.Replace(data.Node, match.Groups[data.Index].ToString()));

            return result;
        }

        /// <summary>
        /// 生成数据的结果
        /// </summary>
        public class GenerateResoult
        {
            /// <summary>
            /// 生成的常量类字符串
            /// </summary>
            public string ConstClassString { get; set; }

            /// <summary>
            /// 属性的类型
            /// </summary>
            public string PropertyType { get; set; }
        }
    }
}
