using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace CodeChallenges
{
    public static class ClimbingTheLeaderboard
    {
        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> playerRanks = new List<int>();
            IEnumerable<int> distinctScores = ranked.Distinct();
            List<int> rankedList = distinctScores.ToList();

            int rankIndex = rankedList.Count - 1;
            for (int i = 0; i < player.Count; i++)
            {
                if (player[i] > rankedList[0]) playerRanks.Add(1);
                else
                {
                    while (player[i] > rankedList[rankIndex])
                        rankIndex--;

                    int rank = player[i] == rankedList[rankIndex] ? rankIndex + 1 : rankIndex + 2;
                    playerRanks.Add(rank);
                }
            }

            return playerRanks;
        }
    }
}
