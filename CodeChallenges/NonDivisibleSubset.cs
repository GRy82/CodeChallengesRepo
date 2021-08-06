using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class NonDivisibleSubset
    {
        // Given a set of distinct integers, print the size of a maximal subset of S where the 
        // sum of any 2 numbers in S' is not evenly divisible by k.

        // Example

        // S = [19,10,12,10,24,25,22], k = 4
        //One of the arrays that can be created is S'[0] = [10, 12, 25]. 
        // Another is S'[1] = [19, 22, 24]. 
        // After testing all permutations, the maximum length solution array has 3 elements.
        public static int nonDivisibleSubset(int k, List<int> s)
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            foreach (var number in s)
            {
                int remainder = number % k;
                if (!occurrences.ContainsKey(remainder))
                    occurrences[remainder] = 1;
                else occurrences[remainder]++;
            }

            int largestPossibleSubset = 0;

            if (occurrences.ContainsKey(0)) largestPossibleSubset++;

            if (k % 2 == 0 && occurrences.ContainsKey(k / 2)) largestPossibleSubset++;

            int currentKey = 1;

            while(currentKey < Math.Ceiling((double)k / 2))
            {
                int currentValue = 0, otherValue = 0;
                if (occurrences.ContainsKey(currentKey)) currentValue = occurrences[currentKey];
                if (occurrences.ContainsKey(k - currentKey)) otherValue = occurrences[k - currentKey];
                largestPossibleSubset += currentValue > otherValue ? currentValue : otherValue;

                currentKey++;
            }

            return largestPossibleSubset;
        }
    }
}
