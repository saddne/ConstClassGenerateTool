using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstGenerateTool
{
    public class Enum
    {
        public class CbxType
        {
            public const string S = "string";

            public const string I = "int";
        }

        public class RegexExample
        {
            public const string A = @"([a-zA-Z\d]+):([a-zA-Z\d]+)\|([^;；:\|]*)";

            public const string B = @"([a-zA-Z\d]+):([a-zA-Z\d]+)";
        }
    }
}
