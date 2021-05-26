using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class PrimeNumberDecomposition
    {
        public static List<int> primeNums = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        public static string Factors(int lst)
        {
            if (lst <= 1) return "You did not enter valid input.";

            return Factors(lst, new StringBuilder(""), 2, 0).ToString();
        }

        public static StringBuilder Factors(int lst, StringBuilder currentString, int attemptedFactor, int primeIndex)
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

            primeIndex++;

            return Factors(lst, currentString, NextPrimeFactor(attemptedFactor, primeIndex), primeIndex);
        }

        public static int NextPrimeFactor(int attemptedFactor, int primeIndex)
        {
            if (primeIndex < primeNums.Count - 1)
                return primeNums[primeIndex];
            else
            {
                do
                {
                    attemptedFactor++;
                } while (!IsPrime(attemptedFactor));
            }

            return attemptedFactor;
        }

        public static bool IsPrime(int number)
        {
            if (primeNums.Contains(number)) return true;

            if(number % 2 == 0 && number != 2) return false;

            int highestPossibleFactor = number / 2 - 1;
            int currentTestedFactor = 3;
            int listIndexOfTestedFactor = 1;

            while(currentTestedFactor < highestPossibleFactor)
            {
                if (number % currentTestedFactor == 0) return false;

                if (listIndexOfTestedFactor < primeNums.Count - 1)
                    currentTestedFactor = primeNums[++listIndexOfTestedFactor];
                else
                    currentTestedFactor++;
            }

            primeNums.Add(number);
            return true;
        }
    }
}
