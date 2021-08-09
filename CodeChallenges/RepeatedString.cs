using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    // There is a string, s, of lowercase English letters that is repeated infinitely many times.
    // Given an integer, n, find and print the number of letter a's in the first n letters of the infinite string.
    public class RepeatedString
    {
        public static long repeatedString(string s, long n)
        {
            long completedReps = n / s.Length;
            int leftoverLetters = (int)(n % s.Length);
            int qtyOfAInS = getAsInS(s);
            return qtyOfAInS * completedReps + getAsInS(s.Substring(0, leftoverLetters));
        }

        static int getAsInS(string s)
        {
            int qtyOfA = 0;
            foreach (char character in s)
                if (character == 'a')
                    qtyOfA++;

            return qtyOfA;
        }
    }
}
