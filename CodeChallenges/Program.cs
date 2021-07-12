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
            ClimbingTheLeaderboard climbingLeaderboard = new ClimbingTheLeaderboard();
            List<int> ranks = climbingLeaderboard.ClimbingLeaderboard(new List<int> {
                100, 90, 90, 80, 75, 60
            },
            new List<int> {
                50, 65, 77, 90, 102
            });
            foreach(var rank in ranks)
                Console.WriteLine(rank);
            new List<int> { 
                50, 65, 77, 90, 102
            }));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms elapsed.");
            Console.ReadLine();
        }
    }
}
