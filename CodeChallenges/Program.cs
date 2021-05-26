using System;
using System.Diagnostics;

namespace CodeChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(PrimeNumberDecomposition.IsPrime(27));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms elapsed.");
            Console.ReadLine();


        }
    }
}
