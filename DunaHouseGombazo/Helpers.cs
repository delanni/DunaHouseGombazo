using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunaHouseGombazo
{
    public static class Helpers
    {
        public static int? TryParseToInt(this string what)
        {
            int result;
            if (Int32.TryParse(what, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static string Nullify(this string original)
        {
            if (string.IsNullOrEmpty(original))
            {
                return null;
            }
            else
            {
                return original;
            }
        }
    }
}
