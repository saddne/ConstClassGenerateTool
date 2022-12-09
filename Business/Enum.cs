using System.Collections.Generic;
using System.Linq;

namespace Business.Enum
{
    public class PropertyType
    {
        public const string String = "string";

        public const string Char = "char";

        public const string Int = "int";

        private static readonly Dictionary<string, string> Names = new Dictionary<string, string>()
            {
                {String,"string" },
                {Char,"char" },
                {Int,"int" },
            };

        public static List<KeyValuePair<string, string>> GetList()
        {
            return Names.ToList(); ;
        }
    }

    public class RegexExample
    {
        public const string A = @"([^\s:：；;，,\|]+)[:：]([^\s:：；;，,\|]+)";

        public const string B = @"([^\s:：；;，,\|]+)[:：]([^\s:：；;，,\|]+)\|([^\s:：；;，,\|]+)";

        private static readonly Dictionary<string, string> Names = new Dictionary<string, string>
        {
            { A, "S:系统,U:用户"},
            { B, "S:1|系统,U:2|用户"},
        };

        public static string[] GetAllKeys()
        {
            return Names.Keys.ToArray();
        }
    }

    public class CommonRegexPattern
    {
        /// <summary>
        /// 适用情景，形如：
        ///     S:系统,U:用户
        ///     S:系统;U:用户
        /// </summary>
        public const string A = @"(?<=^|[;；,，])(\S+?)\s*[:：]\s*(\S+?)(?=$|[;；,，])";

        /// <summary>
        /// 适用情景，形如：
        ///     S:S|系统,U:U|用户
        ///     S:S|系统;U:U|用户
        /// </summary>
        public const string B = @"(?<=^|[;；,，])(\S+?)\s*[:：]\s*(\S+?)\|(\S+?)(?=$|[;；,，])";

        private static readonly Dictionary<string, string> Examples = new Dictionary<string, string>()
        {
            { A, "S:系统,U:用户"},
            { A, "S:1|系统,U:2|用户"},
        };
    }

    public class CommonPrefix
    {
        /// <summary>
        /// Type
        /// </summary>
        public const string T = "T";
        /// <summary>
        /// Code
        /// </summary>
        public const string C = "C";
        /// <summary>
        /// Other
        /// </summary>
        public const string O = "O";
    }

    public class FileName
    {
        public const string RegexSaveFileName = "myRegexTemplet.txt";
    }
}