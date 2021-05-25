using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsScratchPaper
{
    class Program
    {
        public static Dictionary<ulong, ulong> fibTable = new Dictionary<ulong, ulong> { [0] = 0, [1] = 1 };
        public static Dictionary<int, int> indexJumps = new Dictionary<int, int> { };
        static void Main(string[] args)
        {


            //string[] newDirection = dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" });
            //Console.WriteLine(newDirection.ToString());
            //Console.WriteLine(IsValid("[]"));
            //List<char> chars = new List<char> { 'A', 'B', 'C', 'D', 'E' };
            //Random rand = new Random();
            //int removalIndex = rand.Next(0, chars.Count);
            //chars.RemoveAt(removalIndex);
            //Console.WriteLine(IsIsogram("shoubadiy"));
            //Console.WriteLine(DuplicateCount("snoooppy112"));
            //Console.WriteLine(Solution("abc", "bc"));
            //Console.WriteLine(Rot13("A,.6zZn"));
            //Console.WriteLine(HighAndLow("4 5 -1 4"));
            //Console.WriteLine(CountSmileys(new string[] { ":)", ";-D", ":(" }));
            //new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 }
            //Console.WriteLine(comp(new int[] { 2, 3, 3 }, new int[] { 9, 4, 4 }));
            //var two = Fib(2);
            //var eight = Fib(8);
            //var nine = Fib(9);
            //var thing = productFib(714);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(TitleCase("aBc dEf gHi", null));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms elapsed.");
            Console.Read();
        }


        // First argument is title to convert to 'title case'. Second argument is string of words separated by commas,
        // each of which should not be capitalized unless it's the first word of the title.
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

        public static ulong Fib(ulong n)
        {
            if (n <= 1) return n;
            if(!fibTable.ContainsKey(n -1))
                fibTable.Add(n - 1, Fib(n - 1));
            return fibTable[n - 1] + fibTable[n - 2];
        }
     

        public static ulong[] productFib(ulong prod)
        {
            ulong n = 0;
            ulong testProduct;
            do
            {
                testProduct = Fib(n) * Fib(n + 1);
                n++;
            }
            while (testProduct < prod);

            ulong[] result = new ulong[] { Fib(n - 1), Fib(n), 0 };
            if (testProduct == prod) result[2] = 1;
            return result;
        }

        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;

            List<int> aList = a.ToList();
            for (int i = 0; i < b.Length; i++)
            {
                int bSqrt = (int)Math.Sqrt(b[i]);
                if (!aList.Contains(bSqrt))
                    return false;
                aList.Remove(bSqrt);
            }
                
            return true;
        }

        public static int CountSmileys(string[] smileys)
        {
            int count = 0;
            foreach (string face in smileys)
            {
                bool validFace = !((face[0] != ':' && face[0] != ';')
                    || (face[face.Length - 1] != 'D' && face[face.Length - 1] != ')')
                    || (face.Length > 2 && face[face.Length - 2] != '-' && face[face.Length - 2] != '~'));
                if (validFace) count++;
            }
            return count;
        }

        public static string HighAndLow(string numbers)
        {
            string[] thing = numbers.Split(' ');
            int[] nums = Array.ConvertAll<string, int>(thing, Convert.ToInt32);
            Array.Sort(nums);
            int max = nums.Max();
            int min = nums.Min();
            return min.ToString() + " " + max.ToString();
        }

        public static string Rot13(string message)
        {
            StringBuilder newString = new StringBuilder("", 100);

            //A = 65, Z = 90
            //a = 97, z = 122
            foreach (var character in message) {
                if (Char.IsLetter(character))
                {
                    int firstLetter = 97;
                    if (character <= 90)             
                        firstLetter = 65;
                    if (character >= firstLetter + 13)
                        newString.Append((char)(character - (firstLetter + 25) + (firstLetter - 1) + 13));
                    else
                        newString.Append((char)(character + 13));
                }
                else
                    newString.Append(character);
             }


            return newString.ToString();
        }

        public static bool Solution(string str, string ending)
        {
            return (str.Length < ending.Length) ? false : str.Substring(str.Length - ending.Length, ending.Length) == ending;
        }

        public static int DuplicateCount(string str)
        {
            Dictionary<char, bool> dict = new Dictionary<char, bool>();
            foreach (var character in str.ToLower())
                if (dict.ContainsKey(character))
                    dict[character] = true;
                else
                    dict.Add(character, false);

            return dict.Keys.Where(c => dict[c] == true).ToList().Count;
        }

        public static bool IsIsogram(string str)
        {
            HashSet<char> letterSet = new HashSet<char>();
            foreach(char character in str)
            {
                bool successfullyAdded = letterSet.Add(Char.ToUpper(character));
                if (!successfullyAdded) return false;
            }
            return true;
        }

        public static bool IsValid(string s)
        {
            Stack<char> brackets = new Stack<char>();

            foreach (var character in s)
            {
                char topOfStack;
                if (character == '{' || character == '(' ||
                  character == '[')
                    brackets.Push(character);
                if ((character == '}' || character == ')' ||
                  character == ']') && brackets.Count > 0)
                {
                    topOfStack = brackets.Peek();

                    if (topOfStack == '(' && character != ')' ||
                      topOfStack == '{' && character != '}' ||
                      topOfStack == '[' && character != ']')
                        return false;
                    else
                        brackets.Pop();
                }
            }

            if (brackets.Count == 0)
                return true;

            return false;
        }

        public static string[] dirReduc(String[] arr)
        {
            return Recursive(arr);
        }

        public static string[] Recursive(string[] arr)
        {
            string[] newArray;
            int newArrayLength = arr.Length;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == "") continue;
                if (arr[i] == "NORTH" && arr[i + 1] == "SOUTH" ||
                   arr[i] == "SOUTH" && arr[i + 1] == "NORTH" ||
                   arr[i] == "EAST" && arr[i + 1] == "WEST" ||
                   arr[i] == "WEST" && arr[i + 1] == "EAST")
                {
                    arr[i] = "";
                    arr[i + 1] = "";
                    newArrayLength -= 2;
                }
            }
            if (newArrayLength == arr.Length) return arr;

            int index = 0;
            newArray = new string[newArrayLength];
            foreach (var direction in arr)
                if (direction != "")
                    newArray[index++] = direction;

            return Recursive(newArray);
        }

        public static string[] dirReduc2(String[] arr)
        {
            int eastWest = 0;
            int northSouth = 0;

            foreach (string direction in arr)
            {
                switch (direction)
                {
                    case "NORTH":
                        northSouth++;
                        break;
                    case "SOUTH":
                        northSouth--;
                        break;
                    case "EAST":
                        eastWest++;
                        break;
                    case "WEST":
                        eastWest--;
                        break;
                }
            }

            string[] newDirection = GenerateNewString(eastWest, northSouth);
            if (newDirection.Length == 0) return arr;
            return newDirection;

        }
        public static string[] GenerateNewString(int eastWest, int northSouth)
        {
            string[] newDirections = new string[Math.Abs(eastWest) + Math.Abs(northSouth)];

            string eastOrWest = eastWest < 0 ? "WEST" : "EAST";
            string northOrSouth = northSouth < 0 ? "SOUTH" : "NORTH";

            int index = 0;
            int counter = Math.Abs(eastWest);
            while (counter > 0)
            {
                newDirections[index] = eastOrWest;
                index++;
                counter--;
            }


            counter = Math.Abs(northSouth);
            while (counter > 0)
            {
                newDirections[index] = northOrSouth;
                index++;
                counter--;
            }

            return newDirections;
        }


        //public static bool IsValidSudoku(char[,] board)
        //{
        //    List<char> numbersSeenRows = new List<char> { };
        //    List<char> numbersSeenColumns = new List<char> { };
        //    for (int j = 0; j < 9; j++)
        //    {
        //        for (int i = 0; i < 9; i++)
        //        {
        //            if (numbersSeenColumns.Contains(board[j,i]))
        //                return false;
        //            if(board[j, i] != '.')
        //                numbersSeenColumns.Add(board[j,i]);
        //            if (numbersSeenRows.Contains(board[i,j]))
        //                return false;
        //            if (board[i, j] != '.')
        //                numbersSeenRows.Add(board[i,j]);
        //        }
        //        numbersSeenColumns = new List<char> { };
        //        numbersSeenRows = new List<char> { };
        //    }

        //    List<char> numbersSeenSectional = new List<char> { };
        //    for (int i = 0; i < 9; i += 3)
        //    {
        //        int lastIndexRow = i + 2;
        //        for (int j = 0; j < 9; j += 3)
        //        {
        //            int lastIndexColumn = j + 2;
        //            for (int k = i; k <= lastIndexRow; k++)
        //            {
        //                for (int l = j; l <= lastIndexColumn; l++)
        //                {
        //                    if (numbersSeenSectional.Contains(board[k,l]))
        //                        return false;
        //                    if (board[k, l] != '.')
        //                        numbersSeenSectional.Add(board[k,l]);
        //                }
        //            }
        //            numbersSeenSectional = new List<char> { };
        //        }
        //    }
        //    return true;
        //}


        public static bool ValidatePin(string pin)
        {
            int[] acceptableChars = { 47, 48, 49, 50, 51, 52, 53, 54, 55, 56 };
            foreach (var character in pin)
                if (!acceptableChars.Contains(Convert.ToInt32(character)))
                    return false;
            return true;
        }

        public static int minimumStepsToOne(int num)
        {
            int steps = 0;
            while (num != 1)
            {
                if (num % 3 == 0)
                {
                    num /= 3;
                }
                else if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num -= 1;
                }
                steps++;
            }

            return steps;
        }

        public static string Order(string phrase)
        {
            if (phrase == "") return phrase;

            string[] words = phrase.Split(' ');
            string[] newWords = new string[words.Length];
            int wordsSorted = 0;

            for (int j = 1; j <= words.Length; j++)
            {
                foreach (var word in words)
                {
                    bool containedInWord = word.Contains(Convert.ToString(j));
                    if (containedInWord)
                    {
                        newWords[wordsSorted] = word;
                        wordsSorted++;
                        break;
                    }

                }
            }

            string newString = "";
            foreach (var word in newWords)
                newString += " " + word;

            return newString.Trim();
        }
    }
}
