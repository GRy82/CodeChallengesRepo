using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    class FindDigits
    {
        // An integer d is a divisor of an integer n if the remainder of n / d = 0.
        // Given an integer n, for each digit that makes up the integer determine whether it is a divisor.
        // Return the number of divisors occurring within the integer.
        public static int findDigits(int n)
        {
            int divisorsInInteger = 0;

            foreach (var digit in n.ToString().ToCharArray())
                if (digit != '0' && n % (Convert.ToInt32(digit) - 48) == 0) divisorsInInteger++;

            return divisorsInInteger;
        }
    }
}
