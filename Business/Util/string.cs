using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util
{
    public static class @string
    {
        public static bool IsNumeric(this object value)
        {
            double defaultValue;
            return double.TryParse(value.ToString(), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out defaultValue);
        }
    }
}
