﻿using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CodeChallenges
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(PrimeNumberDecomposition.Factors(123456789));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms elapsed.");
            Console.ReadLine();
        }
    }
}
