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
                    char firstLetter = Char.ToUpper(titleWords[i][0]);
                    titleWords[i] = titleWords[i].Remove(0, 1).Insert(0, firstLetter.ToString());
                }
            }

            return string.Join(" ", titleWords);
        }
    }
}
