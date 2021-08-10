﻿using System;
using System.Collections.Generic;
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
            Console.WriteLine(EqualizeArray.EqualizeTheArray(new List<int> { 3, 3, 2, 1, 3 }));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms elapsed.");
            Console.ReadLine();
        }
    }
}
