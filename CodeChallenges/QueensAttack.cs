using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    class QueensAttack
    {
        public static int queensAttack(int boardDimension, int obstacleCount, int queensRow, int queensColumn, 
            List<List<int>> obstacles)//obstacles.Count = obstacleCount. obstacles is a list of lists, each of Count = 2,
                                      //row and column of that particular obstacle. 
        {
            // for each direction that the queen can move(8 directions), a distance of closest obstacle will be identified.
            // otherwise null.
            int[] distanceOfClosestObstacles = setArray(boardDimension, queensRow, queensColumn);

            foreach(var obstacle in obstacles)
            {
                bool diagonalAlignment = Math.Abs(obstacle[0] - queensRow) == Math.Abs(obstacle[1] - queensColumn);
                
                // not possibly in line of attack of the queen
                if (obstacle[0] != queensRow && obstacle[1] != queensColumn && !diagonalAlignment)
                    continue;
                
                // is in line of attack of the queen. Find out which direction it is. 
                int index = getDirectionalIndex(queensRow, queensColumn, obstacle[0], obstacle[1]);
                int obstacleDistance = queensRow != obstacle[0] ? 
                    getDistance(queensRow, obstacle[0]) : getDistance(queensColumn, obstacle[1]);
                // if obstacleDistance is shorter than current value in array, then replace the value in the array.
                if (distanceOfClosestObstacles[index] == 0 || obstacleDistance < distanceOfClosestObstacles[index])
                    distanceOfClosestObstacles[index] = obstacleDistance;    
            }

            int unobstructedMovableSpaces = 0;
            for (int i = 0; i < distanceOfClosestObstacles.Length; i++)
            {
                unobstructedMovableSpaces += distanceOfClosestObstacles[i];
            }

            return unobstructedMovableSpaces;
        }

        static int[] setArray(int boardDimension, int queensRow, int queensColumn)
        {
            int[] array = new int[8];
            array[0] = boardDimension - queensRow;
            array[1] = queensColumn > queensRow ? boardDimension - queensColumn : boardDimension - queensRow;
            array[2] = boardDimension - queensColumn;
            array[3] = queensColumn + queensRow > boardDimension
                ? boardDimension - queensColumn : queensRow - 1;            
            array[4] = queensRow - 1;
            array[5] = queensRow > queensColumn ? queensColumn - 1 : queensRow - 1;
            array[6] = queensColumn - 1;
            array[7] = queensColumn + queensRow > boardDimension
                ? boardDimension - queensRow : queensColumn - 1; 

            return array;
        }

        static int getDistance(int queenCoord, int obstacleCoord)
        {
            return Math.Abs(queenCoord - obstacleCoord) - 1;
        }
        

        static int getDirectionalIndex(int queenRow, int queenColumn, int obstacleRow, int obstacleColumn)
        {
            if (queenColumn == obstacleColumn)
                if (obstacleColumn - queenColumn > 0) return 0;
                else return 4;
            if (queenRow == obstacleRow)
                if (obstacleRow - queenRow > 0) return 2;
                else return 6;
            if (queenRow - obstacleRow > 0 && queenColumn - obstacleColumn > 0) 
                return 5;
            if (queenRow - obstacleRow < 0 && queenColumn - obstacleColumn < 0) 
                return 1;
            if (queenRow - obstacleRow > 0 && queenColumn - obstacleColumn < 0) 
                return 7;
            
            // default/left over direction
            return 3;
        }
    }
}
