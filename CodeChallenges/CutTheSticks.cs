using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class CutTheSticks
    {
        // You are given a number of sticks of varying lengths. You will iteratively cut 
        // the sticks into smaller sticks, discarding the shortest pieces until there are 
        // none left. At each iteration you will determine the length of the shortest stick 
        // remaining, cut that length from each of the longer sticks and then discard all 
        // the pieces of that shortest length. When all the remaining sticks are the same 
        // length, they cannot be shortened so discard them.

        // Given the lengths of n sticks, print the number of sticks that are left before 
        // each iteration until there are none left.
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> stickQtyOverTime = new List<int>();
            arr.Sort();
            while(arr.Count > 0)
            {
                stickQtyOverTime.Add(arr.Count);
                int min = arr[0];
                for (int i = 0; i < arr.Count; i++)
                    arr[i] -= min;
                while (arr.Count > 0 && arr?[0] == 0) arr.RemoveAt(0);
            }

            return stickQtyOverTime;
        }
    }
}
