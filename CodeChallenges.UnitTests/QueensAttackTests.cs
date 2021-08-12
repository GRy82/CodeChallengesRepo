using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenges;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeChallenges.UnitTests
{
    [TestClass]
    public class QueensAttackTests
    {
        //This is the key for method names of tests and what they mean
        // CO - corner obstacle
        // SO - side obstacle
        // PO - perimter obstacle
        // AO - adjacent obstacle
        // CeQ - center queen, followed by direction
        // EQ - edge queen, followed by direction
        // CoQ - corner queen, follwed by direction
        // directions- N, S, E, W, NE, NW, SE, SW
        // directions prefixed with M to indicate midway between center and perimeter.

        [TestMethod]
        public void QueensAttack_CeQCO_ReturnsEight()
        {
            //Arrange
            int boardDimension = 5;
            int obstacleCount = 4;
            int queensRow = 3;
            int queensColumn = 3;
            List<List<int>> obstaclePositions = new List<List<int>>()
            {
                new List<int>{ 4, 2 },
                new List<int>{ 4, 4 },
                new List<int>{ 2, 4 },
                new List<int>{ 2, 2 }
            };
            //Act
            int spacesAvailable = QueensAttack.queensAttack(boardDimension, obstacleCount, queensRow, queensColumn, obstaclePositions);
            //Assert
            Assert.AreEqual(8, spacesAvailable);
        }
        
        [TestMethod]
         public void QueensAttack_CeQSO_ReturnsEight()
        {
            //Arrange
            int boardDimension = 5;
            int obstacleCount = 4;
            int queensRow = 3;
            int queensColumn = 3;
            List<List<int>> obstaclePositions = new List<List<int>>()
            {
                new List<int>{ 3, 2 },
                new List<int>{ 3, 4 },
                new List<int>{ 2, 3 },
                new List<int>{ 4, 3 }
            };
            //Act
            int spacesAvailable = QueensAttack.queensAttack(boardDimension, obstacleCount, queensRow, queensColumn, obstaclePositions);
            //Assert
            Assert.AreEqual(8, spacesAvailable);
        }
    }
}
