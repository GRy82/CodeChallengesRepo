using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    class ExtraLongFactorials
    {
        public static void extraLongFactorials(int n)
        {
            ulong bigInt = Convert.ToUInt64(n);
            for (ulong i = bigInt - 1; i > 0; i--)
                bigInt *= i;
            Console.WriteLine(bigInt.ToString());
        }
    }
}
