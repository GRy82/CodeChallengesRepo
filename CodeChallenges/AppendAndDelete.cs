using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class AppendAndDelete
    {
        // You have two strings of lowercase English letters. You can perform two types of 
        // operations on the first string:
        // 1. Append a lowercase English letter to the end of the string.
        // 2. Delete the last character of the string. Performing this operation on an empty 
        //    string results in an empty string.
        // Given an integer, 'k', and two strings, 's' and 't', determine whether or not you
        // can convert 's' to 't' by performing exactly 'k' of the above operations on 's'. 
        // If it's possible, print Yes. Otherwise, print No.
        public static string appendAndDelete(string s, string t, int k)
        {
            int shorterStringLen = s.Length > t.Length ? t.Length : s.Length;
            int firstDisparateIndex = 0;
            while (firstDisparateIndex < shorterStringLen && s[firstDisparateIndex] == t[firstDisparateIndex])
                firstDisparateIndex++;

            int minDeletions = s.Length - firstDisparateIndex;
            int minAppendments = t.Length - firstDisparateIndex;
            int minStepsRequired = minAppendments + minDeletions;
            bool minStepsIsEven = minStepsRequired % 2 == 0;
            //With K at or above this number, deletions can be made without 
            //risk of making the conversion impossible(making it a "No").
            int freeDeletionFloor = firstDisparateIndex * 2 + minStepsRequired;

            //Return No if more than k steps are required at minimum
            if (k < minStepsRequired)
                return "No";
            //Return Yes if 
            if (k >= freeDeletionFloor)
                return "Yes";
            //At this point, K is at or above minStepsRequired and below freeDeletionFloor
            //Return No if even/odd-ness does not match k.
            if ((minStepsIsEven && k % 2 == 1) || (!minStepsIsEven && k % 2 == 0))
                return "No";

            return "Yes";
        }
    }
}
