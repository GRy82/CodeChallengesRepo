using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{

    // The Utopian Tree goes through 2 cycles of growth every year.Each spring, it doubles in height.Each summer, its height increases by 1 meter.
    // A Utopian Tree sapling with a height of 1 meter is planted at the onset of spring.How tall will the tree be after  growth cycles?
    public class UtopianTree
    {
        public int utopianTree(int growthCycles)
        {
            int treeHeight = 1;
            bool isSpring = true;
            while(growthCycles > 0)
            {
                if (isSpring) treeHeight *= 2;
                else treeHeight += 1;
                isSpring = !isSpring;
                growthCycles--;
            }
            return treeHeight;
        }
    }
}
