using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCApp.Core
{
    public static class SuppliedHashFunction
    {
        public static long Hash(string stringToHash)
        {
            var hashResult = ProblemConstants.StartingNumber;
            const string Letters = ProblemConstants.RangeOfLettersUsed;

            for (int i = 0; i < stringToHash.Length; i++)
            {
                hashResult = (hashResult * ProblemConstants.MagicNumber + Letters.IndexOf(stringToHash[i]));
            }

            return hashResult;
        }
    }

    public static class ProblemConstants
    {
        public const string RangeOfLettersUsed = "acdegilmnoprstuw";
        public const long StartingNumber = 7;
        public const int MagicNumber = 37;

    }
}
