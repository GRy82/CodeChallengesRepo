using System;
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
            //Console.WriteLine(QueensAttack.queensAttack(88587, 9, 20001, 20003, new List<List<int>> { 
            //    new List<int>{ 20001, 20002},
            //    new List<int>{ 20001, 20004},
            //    new List<int>{ 20000, 20003},
            //    new List<int>{ 20002, 20003},
            //    new List<int>{ 20000, 20004},
            //    new List<int>{ 20000, 20002},
            //    new List<int>{ 20002, 20004},
            //    new List<int>{ 20002, 20002},
            //    new List<int>{ 564, 323},
            //}));
            var answer = TopicsKnown.acmTeam(new List<string> { "10101", "11100", "11010", "00101" });
            Console.WriteLine("highest number of topics known by a team: " + answer[0] + "\nnumber of teams knowing that many topics: " + answer[1]);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms elapsed.");
            Console.ReadLine();
        }
    }
}
