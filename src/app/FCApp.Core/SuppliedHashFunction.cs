using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCApp.Core
{
    public static class SuppliedHashFunction
    {
        public static long Hash(string s)
        {
            long h = 7;
            string letters = "acdegilmnoprstuw";

            for (int i = 0; i < s.Length; i++)
            {
                h = (h * 37 + letters.IndexOf(s[i]));
            }
            return h;
        }
    }
}
