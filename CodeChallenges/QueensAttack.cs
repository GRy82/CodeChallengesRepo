using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class QueensAttack
    {
        public static int queensAttack(int boardDimension, int obstacleCount, int queensRow, int queensColumn, 
            List<List<int>> obstacles)//obstacles.Count = obstacleCount. obstacles is a list of lists, each of Count = 2,
                                      //row and column of that particular obstacle. 
        {
            // for each direction that the queen can move(8 directions), a distance of closest obstacle will be identified.
            // otherwise null.
            //int[] distanceOfClosestObstacles = setArray(boardDimension, queensRow, queensColumn);
            Dictionary<string, int> distanceOfClosestObstacles = setDict(boardDimension, queensRow, queensColumn);

            foreach(var obstacle in obstacles)
            {
                bool diagonalAlignment = Math.Abs(obstacle[0] - queensRow) == Math.Abs(obstacle[1] - queensColumn);
                
                // not possibly in line of attack of the queen
                if (obstacle[0] != queensRow && obstacle[1] != queensColumn && !diagonalAlignment)
                    continue;
                
                // is in line of attack of the queen. Find out which direction it is. 
                var direction = getDirectionalKey(queensRow, queensColumn, obstacle[0], obstacle[1]);
                int obstacleDistance = queensRow != obstacle[0] ? 
                    getDistance(queensRow, obstacle[0]) : getDistance(queensColumn, obstacle[1]);
                // if obstacleDistance is shorter than current value in array, then replace the value in the array.
                if (distanceOfClosestObstacles[direction] == 0 || obstacleDistance < distanceOfClosestObstacles[direction])
                    distanceOfClosestObstacles[direction] = obstacleDistance;    
            }

            int unobstructedMovableSpaces = 0;
            foreach (var key in distanceOfClosestObstacles.Keys)
            {
                unobstructedMovableSpaces += distanceOfClosestObstacles[key];
            }

            return unobstructedMovableSpaces;
        }

        static Dictionary<string, int> setDict(int boardDimension, int queensRow, int queensColumn)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["N"] = boardDimension - queensRow;
            dict["NE"] = queensColumn > queensRow ? boardDimension - queensColumn : boardDimension - queensRow;
            dict["E"] = boardDimension - queensColumn;
            dict["SE"] = queensColumn + queensRow > boardDimension
                ? boardDimension - queensColumn : queensRow - 1;            
            dict["S"] = queensRow - 1;
            dict["SW"] = queensRow > queensColumn ? queensColumn - 1 : queensRow - 1;
            dict["W"] = queensColumn - 1;
            dict["NW"] = queensColumn + queensRow > boardDimension
                ? boardDimension - queensRow : queensColumn - 1; 

            return dict;
        }

        static int getDistance(int queenCoord, int obstacleCoord)
        {
            return Math.Abs(queenCoord - obstacleCoord) - 1;
        }
        

        static string getDirectionalKey(int queenRow, int queenColumn, int obstacleRow, int obstacleColumn)
        {
            if (queenColumn == obstacleColumn)
                if (obstacleRow - queenRow > 0) return "N";
                else return "S";
            if (queenRow == obstacleRow)
                if (obstacleColumn - queenColumn > 0) return "E";
                else return "W";
            if (queenRow - obstacleRow > 0 && queenColumn - obstacleColumn > 0) 
                return "SW";
            if (queenRow - obstacleRow < 0 && queenColumn - obstacleColumn < 0) 
                return "NE";
            if (queenRow - obstacleRow > 0 && queenColumn - obstacleColumn < 0) 
                return "NW";
            
            // default/left over direction
            return "SE";
        }
    }
}
