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
        // CeQ - center queen
        // EQ - edge queen, followed by direction
        // CoQ - corner queen, follwed by direction

        // directions prefixed with M to indicate midway between center and perimeter.

        // CO - corner obstacle
        // SO - side obstacle
        // PO - perimter obstacle
        // AO - adjacent obstacle
        // directions- N, S, E, W, NE, NW, SE, SW

        [TestMethod]
        public void QueensAttack_Ce_QCOAO_ReturnsEight()
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
        public void QueensAttack_CeQ_SOAO_ReturnsEight()
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

        [TestMethod]
        public void QueensAttack_CeQ_SOCOAO_ReturnsZero()
        {
            //Arrange
            int boardDimension = 5;
            int obstacleCount = 8;
            int queensRow = 3;
            int queensColumn = 3;
            List<List<int>> obstaclePositions = new List<List<int>>()
            {
                new List<int>{ 3, 2 },
                new List<int>{ 3, 4 },
                new List<int>{ 2, 3 },
                new List<int>{ 4, 3 },
                new List<int>{ 4, 2 },
                new List<int>{ 4, 4 },
                new List<int>{ 2, 4 },
                new List<int>{ 2, 2 }
            };
            //Act
            int spacesAvailable = QueensAttack.queensAttack(boardDimension, obstacleCount, queensRow, queensColumn, obstaclePositions);
            //Assert
            Assert.AreEqual(0, spacesAvailable);
        }


        [TestMethod]
        public void QueensAttack_CeQ_SOPO_ReturnsTwelve()
        {
            //Arrange
            int boardDimension = 5;
            int obstacleCount = 4;
            int queensRow = 3;
            int queensColumn = 3;
            List<List<int>> obstaclePositions = new List<List<int>>()
            {
                new List<int>{ 3, 5 },
                new List<int>{ 3, 1 },
                new List<int>{ 1, 3 },
                new List<int>{ 5, 3 }
            };
            //Act
            int spacesAvailable = QueensAttack.queensAttack(boardDimension, obstacleCount, queensRow, queensColumn, obstaclePositions);
            //Assert
            Assert.AreEqual(12, spacesAvailable);
        }

        [TestMethod]
        public void QueensAttack_CeQ_COPO_ReturnsTwelve()
        {
            //Arrange
            int boardDimension = 5;
            int obstacleCount = 4;
            int queensRow = 3;
            int queensColumn = 3;
            List<List<int>> obstaclePositions = new List<List<int>>()
            {
                new List<int>{ 1, 1 },
                new List<int>{ 5, 5 },
                new List<int>{ 5, 1 },
                new List<int>{ 1, 5 }
            };
            //Act
            int spacesAvailable = QueensAttack.queensAttack(boardDimension, obstacleCount, queensRow, queensColumn, obstaclePositions);
            //Assert
            Assert.AreEqual(12, spacesAvailable);
        }

    }
}
