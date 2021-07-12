using System;
using System.Collections.Generic;
using System.Text;

// When a contiguous block of text is selected in a PDF viewer, the selection is 
// highlighted with a blue rectangle. In this PDF viewer, each word is highlighted 
// independently.

// There is a list of 26 character heights aligned by index to their letters. For 
// example, 'a' is at index 0 and 'z' is at index 25. There will also be a string.
// Using the letter heights given, determine the area of the rectangle highlight in 
// mm^2 assuming all letters are 1mm wide.

namespace CodeChallenges
{
    public static class DesignerPDFViewer
    {
        public static int DesignerPDF(List<int> alphaHeights, string word) 
        {
            int[] wordLetterHeights = new int[word.Length];
            var wordCharArray = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
                wordLetterHeights[i] = alphaHeights[word[i] - 97];
            
            int maxHeight = 0;
            foreach (var height in wordLetterHeights)
                if (height > maxHeight)
                    maxHeight = height;

            return maxHeight * word.Length;
        }
    }
}
