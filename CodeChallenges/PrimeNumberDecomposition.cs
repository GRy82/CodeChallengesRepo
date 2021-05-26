using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class PrimeNumberDecomposition
    {
        public static string Factors(int lst)
        {
            if (lst < 1) return "You must enter a number greater than '1'";

            return PrimeFactor(lst, new StringBuilder(""));
        }

        public static string PrimeFactor(int lst, StringBuilder currentString)
        {

            return "";
        }
    }
}
