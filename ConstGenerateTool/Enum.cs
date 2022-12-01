using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstGenerateTool
{
    public class Enum
    {
        public class PropertyType
        {
            public const string S = "string";

            public const string C = "char";

            public const string I = "int";

            private static readonly Dictionary<string, string> Names = new Dictionary<string, string>()
            {
                {S,"string" },
                {C,"char" },
                {I,"int" },
            };

            public static List<KeyValuePair<string, string>> GetList()
            {
                return Names.ToList(); ;
            }
        }

        public class RegexExample
        {
            public const string A = @"([^\s:：；;，,\|]+):([^\s:：；;，,\|]+)\|([^\s:：；;，,\|]+)";

            public const string B = @"([^\s:：；;，,\|]+):([^\s:：；;，,\|]+)";
        }
    }
}
