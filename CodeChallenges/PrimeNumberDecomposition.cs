using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class PrimeNumberDecomposition
    {
        public static HashSet<int> primeNums = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 23, 29 };

        public static string Factors(int lst)
        {
            if (lst < 1) return "No Bueno!";

            return Factors(lst, new StringBuilder(""), 2).ToString();
        }

        public static StringBuilder Factors(int lst, StringBuilder currentString, int attemptedFactor)
        {
            if (IsPrime(lst))         
                return currentString.Append("(").Append(lst).Append(")");

            int consecutiveFactorCount = 0;
            while (lst % attemptedFactor == 0)
            {
                consecutiveFactorCount++;
                lst /= attemptedFactor;
            }

            if (consecutiveFactorCount == 1)
                currentString.Append("(").Append(attemptedFactor).Append(")");
            if(consecutiveFactorCount > 1)
                currentString.Append("(").Append(attemptedFactor).Append("**").
                    Append(consecutiveFactorCount).Append(")");

            return Factors(lst, currentString, NextPrimeFactor(attemptedFactor));
        }

        public static int NextPrimeFactor(int attemptedFactor)
        {
            do
            {
                attemptedFactor++;
            } while (!IsPrime(attemptedFactor));

            return attemptedFactor;
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

            primeNums.Add(attemptedFactor);
            return true;
        }
    }
}
