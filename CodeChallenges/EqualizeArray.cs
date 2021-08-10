using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    // Given an array of integers, determine the minimum number of elements to delete to leave only elements of equal value.
    public class EqualizeArray
    {
        public static int EqualizeTheArray(List<int> arr)
        {
            Dictionary<int, int> intOccurrences = new Dictionary<int, int>();
            foreach (var number in arr)
            {
                bool keyExists = intOccurrences.TryAdd(number, 1);
                if (!keyExists)
                    intOccurrences[number]++;
            }

            int maxOccurrences = 0;
            foreach (var key in intOccurrences.Keys)
                if (intOccurrences[key] > maxOccurrences)
                    maxOccurrences = intOccurrences[key];

            return arr.Count - maxOccurrences;
        }
    }
}
