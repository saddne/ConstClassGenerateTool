using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstGenerateTool
{
    internal class ConstGenerateUtil
    {
        /// <summary>
        /// 生成常量类
        /// </summary>
        /// <returns></returns>
        public static GenerateResoult CreateConstClassProperties(string className, string propertyType, string preText, List<ConstProperty> properties)
        {
            // 类名
            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("类名不可为空！");
                return null;
            }

            if (string.IsNullOrEmpty(propertyType))
            {
                if (properties.All(p => Regex.IsMatch(p.Value, @"^[0\d]*$"))) // 属性列表中的值都是数字
                {
                    propertyType = Enum.PropertyType.I;
                }
                else
                {
                    propertyType = Enum.PropertyType.S;
                }
            }
            if (properties.All(p => Regex.IsMatch(p.Key, @"^[0\d]*$"))) // Key都为数字
            {
                if (string.IsNullOrEmpty(preText))
                {
                    preText = "C";
                }
            }

            string summary = "/// <summary>";
            string summaryText = string.Format("/// ");
            string endSummary = "/// </summary>";
            string classNameStr = string.Format("public class {0}", className);
            string lBbrace = "{";
            string rbrace = "}";
            string blankLBrace = "    {";
            string blankRBrace = "    }";

            string blankSummary = "    /// <summary>";
            string blankEndSummary = "    /// </summary>";
            string blankSummaryValueFormat = "    /// {0}";
            string constPropertyFormat = "";
            if (propertyType == Enum.PropertyType.S)
            {
                constPropertyFormat = "    public const " + propertyType + " " + preText + "{0} = \"{1}\";";
            }
            else if (propertyType == Enum.PropertyType.I)
            {
                constPropertyFormat = "    public const " + propertyType + " " + preText + "{0} = {1};";
            }
            else if (propertyType == Enum.PropertyType.C)
            {
                constPropertyFormat = "    public const " + propertyType + " " + preText + "{0} = \"{1}\";";
            }

            StringBuilder sBuilder = new StringBuilder();

            sBuilder.AppendLine(summary);
            sBuilder.AppendLine(summaryText);
            sBuilder.AppendLine(endSummary);
            sBuilder.AppendLine(classNameStr);
            sBuilder.AppendLine(lBbrace);

            foreach (var property in properties)
            {
                sBuilder.AppendLine(blankSummary);
                sBuilder.AppendLine(string.Format(blankSummaryValueFormat, property.DText));
                sBuilder.AppendLine(blankEndSummary);
                sBuilder.AppendLine(string.Format(constPropertyFormat, property.Key, property.Value));
                sBuilder.AppendLine();
            }

            #region Names

            sBuilder.AppendLine(string.Format("    private static readonly Dictionary<{0},string> Names = new Dictionary<{0},string>()", propertyType));
            sBuilder.AppendLine(blankLBrace);
            foreach (var property in properties)
            {
                sBuilder.AppendLine(string.Format("        {{ {0}, \"{1}\" }},", property.Key, property.DText));
            }
            sBuilder.AppendLine("    };");
            sBuilder.AppendLine();

            #endregion

            #region GetAllKeys

            sBuilder.AppendLine(string.Format("    public static {0}[] GetAllKeys()", propertyType));
            sBuilder.AppendLine(blankLBrace);
            sBuilder.AppendLine("        return Names.Keys.ToArray();");
            sBuilder.AppendLine(blankRBrace);
            sBuilder.AppendLine();

            #endregion

            #region GetName

            sBuilder.AppendLine(string.Format("    public static string GetName({0} key)", propertyType));
            sBuilder.AppendLine(blankLBrace);
            sBuilder.AppendLine("       if (Names.ContainsKey(key))");
            sBuilder.AppendLine("           return Names[key];");
            sBuilder.AppendLine("       else");
            sBuilder.AppendLine("           return string.Empty;");
            sBuilder.AppendLine(blankRBrace);
            sBuilder.AppendLine();

            #endregion

            #region GetList

            sBuilder.AppendLine(string.Format("    public static List<KeyValuePair<{0}, string>> GetList()", propertyType));
            sBuilder.AppendLine(blankLBrace);
            sBuilder.AppendLine("        return Names.ToList();");
            sBuilder.AppendLine(blankRBrace);

            #endregion

            sBuilder.Append(rbrace);

            GenerateResoult result = new GenerateResoult();
            result.ConstClassString = sBuilder.ToString();
            result.PropertyType = propertyType;
            return result;
        }

        /// <summary>
        /// 将输入字符串转为属性类列表
        /// </summary>
        /// <returns></returns>
        public static List<ConstProperty> ConvertTextToPropertyList(string regexText, string inputText)
        {
            regexText = regexText.Trim();
            if (string.IsNullOrEmpty(regexText))
            {
                MessageBox.Show("正则表达式不可为空！");
                return null;
            }

            inputText = inputText.Trim();
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("输入内容不可为空！");
                return null;
            }

            List<ConstProperty> properties = new List<ConstProperty>();
            try
            {
                if (regexText.Equals(Enum.RegexExample.A))
                {
                    #region A

                    if (!Regex.IsMatch(inputText, Enum.RegexExample.A))
                    {
                        MessageBox.Show("输入内容与正则表达式不匹配！");
                        return null;
                    }

                    var list = Regex.Matches(inputText, Enum.RegexExample.A);
                    foreach (Match match in list)
                    {
                        properties.Add(new ConstProperty
                        {
                            Key = match.Groups[1].Value,
                            Value = match.Groups[2].Value,
                            DText = string.IsNullOrEmpty(match.Groups[3].Value) ? match.Groups[2].Value : match.Groups[3].Value
                        });
                    }

                    #endregion
                }
                else if (regexText.Equals(Enum.RegexExample.B))
                {
                    #region B

                    if (!Regex.IsMatch(inputText, Enum.RegexExample.B))
                    {
                        MessageBox.Show("输入内容与正则表达式不匹配！");
                        return null;
                    }

                    var list = Regex.Matches(inputText, Enum.RegexExample.B);
                    foreach (Match item in list)
                    {
                        properties.Add(new ConstProperty
                        {
                            Key = item.Groups[1].Value,
                            Value = item.Groups[2].Value,
                            DText = item.Groups[2].Value,
                        });
                    }

                    #endregion
                }
                else
                {
                    #region 其他

                    if (!Regex.IsMatch(regexText, @"([a-zA-Z\[\]\+\-\(\\)\\0-9]+)([：:])([a-zA-Z\[\]\+\-\(\\)\\0-9]+)"))
                    {
                        MessageBox.Show("当前正则表达式不符合规则，请编辑后重试！");
                        return null;
                    }

                    if (!Regex.IsMatch(inputText, regexText))
                    {
                        MessageBox.Show("输入内容与正则表达式不匹配！");//若确认无错误，则联系开发者查看代码是否有bug
                        return null;
                    }

                    var list = Regex.Matches(inputText, regexText);
                    foreach (Match match in list)
                    {
                        properties.Add(new ConstProperty
                        {
                            Key = match.Groups[1].Value,
                            Value = match.Groups[2].Value,
                            DText = string.IsNullOrEmpty(match.Groups[3].Value) ? match.Groups[2].Value : match.Groups[3].Value
                        });
                    }

                    #endregion
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            return properties;
        }

        public class ConstProperty
        {
            public string Key { get; set; }

            public string Value { get; set; }

            public string DText { get; set; }
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
