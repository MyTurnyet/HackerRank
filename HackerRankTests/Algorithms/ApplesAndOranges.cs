using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class ApplesAndOranges
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnPositionOfOrangeFall()
        {
            //arrange
            int orangeTreeLocation = 15;
            //act
            int orangFallLocation = FruitFallLocation(orangeTreeLocation, 5);
            //assert
            orangFallLocation.Should().Be(20);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldShowFruitHitsHouse()
        {
            //arrange
            int leftSideOfHouse = 7;
            int rightSideOfHouse = 11;
            int orangFallLocation = 9;
            //act
            bool hitsHouse = FruitHitsHouse(leftSideOfHouse, rightSideOfHouse, orangFallLocation);
            //assert
            hitsHouse.Should().BeTrue();
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldCountNumberOfHitsOnRoof()
        {
            //arrange
            int leftSideOfHouse = 7;
            int rightSideOfHouse = 11;
            int treeLocation = 15;
            int[] appleFall = new[] { 5, -6 ,-4};
            int totalAppleHits = 0;
            //act
            totalAppleHits = TotalHitsOnHouse(appleFall, leftSideOfHouse, rightSideOfHouse, treeLocation);

            //assert
            totalAppleHits.Should().Be(2);
        }

        private static int TotalHitsOnHouse(int[] fruitFallLocations, int leftSideOfHouse, int rightSideOfHouse, int treeLocation)
        {
            int totalAppleHits = 0;
            foreach (int appleDeviation in fruitFallLocations)
            {
                if (FruitHitsHouse(leftSideOfHouse, rightSideOfHouse,FruitFallLocation(treeLocation, appleDeviation))) totalAppleHits++;
            }
            return totalAppleHits;
        }

        private static bool FruitHitsHouse(int leftSideOfHouse, int rightSideOfHouse, int fruitFallLocation) => leftSideOfHouse <= fruitFallLocation && rightSideOfHouse >= fruitFallLocation;
        private static int FruitFallLocation(int treeLocation, int fallLocation) => treeLocation + fallLocation;
    }
}
