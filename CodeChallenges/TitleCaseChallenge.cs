using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeChallenges
{
    public static class TitleCaseChallenge
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            string titleString = title.ToLower();
            string[] minorWordsArray = minorWords != null && minorWords.Length > 0 ?
                minorWords.ToLower().Trim().Split(' ') : new string[0];
            string[] titleWords = titleString.Split(' ');
            for (int i = 0; i < titleWords.Length; i++)
            {
                if (titleWords[i].Length < 1) continue;
                if (!minorWordsArray.Contains(titleWords[i]) || i == 0)
                {
                    char firstLetter = titleWords[i][0];
                    firstLetter = Char.ToUpper(firstLetter);
                    char[] charArray = titleWords[i].ToCharArray();
                    charArray[0] = firstLetter;
                    titleWords[i] = String.Join("", charArray);
                }
            }

            return string.Join(" ", titleWords);
        }
    }
}
