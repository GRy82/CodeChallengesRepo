using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

    // An arcade game player wants to climb to the top of the leaderboard and track their ranking.The game uses Dense Ranking,
    // so its leaderboard works like this:

    // The player with the highest score is ranked number  on the leaderboard.

    // Players who have equal scores receive the same ranking number, and the next player(s) receive the immediately following
    // ranking number.

    // climbingLeaderboard has the following parameter(s) :
    // - int player[n]: the leaderboard scores
    // - int player[m]: the player's scores

    // Returns:
    // int[m]: the player's rank after each new score

namespace CodeChallenges
{


    public class ClimbingTheLeaderboard
    {
        public List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
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
