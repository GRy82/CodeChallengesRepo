using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public static class TopicsKnown
    {
        /*
        There are a number of people who will be attending ACM-ICPC World Finals.Each of them may be well versed in a number 
        of topics.Given a list of topics known by each attendee, presented as binary strings, determine the maximum number 
        of topics a 2-person team can know. Each subject has a column in the binary string, and a '1' means the subject
        is known while '0' means it is not.Also determine the number of teams that know the maximum number of topics.
        Return an integer array with two elements.The first is the maximum number of topics known, and the second is 
        the number of teams that know that number of topics.
        */

        public static List<int> acmTeam(List<string> topicsSet)
        {
            Dictionary<int[], int> subjectsKnownByPair = new Dictionary<int[], int>();

            /* The way the nested loop is setup, we will never encounter any repeat pairs that are just ordered differently
            *  Also, no team member will ever be attempted to be "paired" with themselves.
            */
            for (int i = 0; i < topicsSet.Count; i++)
            {
                for (int j = i + 1; j < topicsSet.Count; j++)
                {
                    int[] pair = { i, j };
                    subjectsKnownByPair[pair] = topicsKnownByTeam(topicsSet, i, j);
                }
            }

            return MaxTopicsKnownAndFrequencyOfMax(subjectsKnownByPair);
        }

        private static int topicsKnownByTeam(List<String> topicsSet, int memberOne, int memberTwo)
        {
            int numberOfTopicsKnown = 0;

            char[] topicsSetCharArrOne = topicsSet[memberOne].ToCharArray();
            char[] topicsSetCharArrTwo = topicsSet[memberTwo].ToCharArray();
            for (int i = 0; i < topicsSet[0].Length; i++)
            {
                if (topicsSetCharArrOne[i] == '1' || topicsSetCharArrTwo[i] == '1')
                    numberOfTopicsKnown++;
            }

            return numberOfTopicsKnown;
        }

        private static List<int> MaxTopicsKnownAndFrequencyOfMax(Dictionary<int[], int> subjectsKnownByPair)
        {
            int maxSubjectsKnown = 0;
            int maxSubjectsKnownFrequency = 0;

            foreach (var pair in subjectsKnownByPair.Keys)
            {
                if (subjectsKnownByPair[pair] > maxSubjectsKnown)
                {
                    maxSubjectsKnown = subjectsKnownByPair[pair];
                    maxSubjectsKnownFrequency = 1;
                }
                else if (subjectsKnownByPair[pair] == maxSubjectsKnown)
                    maxSubjectsKnownFrequency++;
            }

            return new List<int> { maxSubjectsKnown, maxSubjectsKnownFrequency };
        }
    }
}
