using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    //Watson likes to challenge Sherlock's math ability. He will provide a starting and ending value that describe a range of integers,
    // inclusive of the endpoints. Sherlock must determine the number of square integers within that range.

    //Note: A square integer is an integer which is the square of an integer, e.g. 1,4,9,16,25.

    //Example a = 24, b = 49


    //There are three square integers in the range: 25,36 and 49.Return 3.

    //Function Description

    //Complete the squares function in the editor below.It should return an
    //integer representing the number of square integers in the inclusive range from a to b.

    //squares has the following parameter(s) :

    //int a: the lower range boundary
    //int b: the upper range boundary
    //Returns

    //int: the number of square integers in the range
    public class SherlockAndSquares
    {
        public static int Squares(int a, int b)
        {
            int firstPossibleInteger = Convert.ToInt32(Math.Ceiling(Math.Sqrt(a)));
            int lastPossibleInteger = Convert.ToInt32(Math.Floor(Math.Sqrt(b)));

            return lastPossibleInteger - firstPossibleInteger + 1;
        }
    }
}
