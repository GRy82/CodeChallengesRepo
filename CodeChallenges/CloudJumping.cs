using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    // There is a new mobile game that starts with consecutively numbered clouds.Some of the clouds are thunderheads and others are cumulus.
    // The player can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus 1 or 2. The player must
    // avoid the thunderheads. Determine the minimum number of jumps it will take to jump from the starting postion to the last cloud.It is
    // always possible to win the game.

    // For each game, you will get an array of clouds numbered 0 if they are safe or 1 if they must be avoided.
    public class CloudJumping
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int jumpCount = 0;
            int currentCloud = 0;
            do
            {
                if (currentCloud < c.Count - 2 && c[currentCloud + 2] != 1)
                    currentCloud += 2;
                else 
                    currentCloud++;
                jumpCount++;
            } while (currentCloud < c.Count - 1);

            return jumpCount;
        }
    }
}
