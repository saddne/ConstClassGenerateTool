using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Business.Enum;

namespace Business.ConstClass
{
    public class ConstClassFieldModel
    {
        public string FieldName { get; set; }

        public string FieldValue { get; set; }

        public string FieldSummary { get; set; }
    }

    public class ConstClassParamModel
    {
        public string ClassName { get; set; }

        public string ClassSummary { get; set; }

        public string RegexPattern { get; set; }

        public string InputString { get; set; }

        public string GeneratedFieldType { get { return GetFieldPatternProperty(p => p.GeneratedFieldType); } }

        public string FieldType { get { return GetFieldPatternProperty(p => p.FieldType); } }

        public string FieldPrefix { get { return GetFieldPatternProperty(p => p.FieldPrefix); } }

        public FieldPattern CustomFieldPattern { get; set; }

        public FieldPattern GenerateFieldPattern { get; set; }

        public List<ConstClassFieldModel> FieldModels { get; set; }

        public void Validation()
        {
            if (string.IsNullOrWhiteSpace(RegexPattern))
            {
                throw new Exception("正则表达式不可为空！");
            }
            if (string.IsNullOrWhiteSpace(InputString))
            {
                throw new Exception("输入字符串不可为空！");
            }

            if (!Regex.IsMatch(InputString, RegexPattern))
            {
                throw new Exception("输入字符串与正则表达式不符，请检查后重试！");
            }

            if (string.IsNullOrEmpty(ClassName))
            {
                throw new Exception("类名不可为空！");
            }
        }

        public string GetFieldPatternProperty(Func<FieldPattern, string> getProperty)
        {
            return (this.CustomFieldPattern == null || string.IsNullOrWhiteSpace(getProperty(CustomFieldPattern))) ? getProperty(this.GenerateFieldPattern) : getProperty(CustomFieldPattern);
        }
    }

    public class FieldPattern
    {
        public string FieldNamePattern { get; set; } = "";
        public string FieldValuePattern { get; set; } = "";

        public string FieldSummaryPattern { get; set; } = "";

        public string GeneratedFieldType { get; set; }

        public string FieldType { get; set; }

        public string FieldPrefix { get; set; }
    }
}
