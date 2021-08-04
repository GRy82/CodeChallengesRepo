using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{

    // Your local library needs your help! Given the expected and actual return dates for a library book, create a program that calculates the fine (if any). The fee structure is as follows:

    // If the book is returned on or before the expected return date, no fine will be charged(i.e.: fine = 0.)
    // If the book is returned after the expected return day but still within the same calendar month and year as the expected return date, fine = 15 Hackos * number of days late.
    // If the book is returned after the expected return month but still within the same calendar year as the expected return date, fine = 500 Hackos * number of months late..
    // If the book is returned after the calendar year in which it was expected, there is a fixed fine of 10,000 Hackos.
    // Charges are based only on the least precise measure of lateness.For example, whether a book is due January 1, 2017 or December 31, 2017, if it is returned January 1, 2018, that is a year late and the fine would be 10000 Hackos.
    public class LibraryFine
    {
        // first is when returned, second set of values represents when due.
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int y = y1 - y2;
            int m = m1 - m2;
            int d = d1 - d2;

            bool onTime = isOnTime(y, m, d);
            if (onTime) return 0;

            if (y == 0 && m == 0) return d * 15;
            if (y == 0) return m * 500;
            return 10000;
        }

        static bool isOnTime(int y, int m, int d)
        {
            if (y < 0) return true;
            if (y == 0 && m < 0) return true;
            if (y == 0 && m == 0 && d <= 0) return true;

            return false;
        }
    }
}
