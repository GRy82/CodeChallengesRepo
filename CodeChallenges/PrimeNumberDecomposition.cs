using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class PrimeNumberDecomposition
    {

        public static HashSet<int> primeNums = new HashSet<int> { };
        public static string Factors(int lst)
        {
            if (lst < 1) return "You must enter a number greater than '1'";

            return HighestPrimeFactor(lst, new StringBuilder(""));
        }

        public static string HighestPrimeFactor(int lst, StringBuilder currentString)
        {
            //int nextPrimeFactor = GetNextPrimeFactor();
            return "";
        }

        public int GetnextPrimeFactor(int number)
        {

            return 4;
            
        }

        public static bool IsPrime(int number)
        {
            if (primeNums.Contains(number)) return true;

            if(number % 2 == 0 && number != 2) return false;
            int lowestPossibleFactor = 2;
            int attemptedFactor = number / 2 - 1;

            while (attemptedFactor > lowestPossibleFactor)
            {
                if (number % attemptedFactor == 0)
                    return false;
                attemptedFactor--;
            }

            primeNums.Add(number);
            return true;
        }
    }
}
