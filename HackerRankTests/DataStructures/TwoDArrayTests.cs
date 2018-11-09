using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.DataStructures
{
    [TestClass]
    public class TwoDArrayTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldFindHourGlassSum_7_In3X3Array()
        {
            //assign
            int[][] testArray = {new[] {1, 1, 1}, new[] {0, 1, 0}, new[] {1, 1, 1}};
            //act
            int sum = HourglassSum(testArray);

            //assert
            sum.Should().Be(7);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldFindHourGlassSum_11_In3X3Array()
        {
            //assign
            int[][] testArray = {new[] {2, 1, 2}, new[] {1, 1, 1}, new[] {2, 1, 2}};
            //act
            int sum = HourglassSum(testArray);

            //assert
            sum.Should().Be(11);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldFindHourGlassSum_11_In5X5Array()
        {
            //assign
            int[][] testArray =
            {
                new[] {2, 1, 2, 0, 1}, new[] {0, 1, 0, 1, 1}, new[] {2, 1, 2, 1, 1}, new[] {0, 1, 0, 1, 1},
                new[] {0, 1, 0, 1, 1}
            };
            //act
            int sum = HourglassSum(testArray);

            //assert
            sum.Should().Be(11);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldFindHourGlassSum_28_In6x6Array()
        {
            //assign
            int[][] testArray =
            {
                new[] {-9, -9, -9, 1, 1, 1},
                new[] {0, -9, 0, 4, 3, 2},
                new[] {-9, -9, -9, 1, 2, 3},
                new[] {0, 0, 8, 6, 6, 0},
                new[] {0, 0, 0, -2, 0, 0},
                new[] {0, 0, 1, 2, 4, 0}
            };
            //act
            int sum = HourglassSum(testArray);

            //assert
            sum.Should().Be(28);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldFindHourGlassSum_19_In6x6Array()
        {
            //assign
            int[][] testArray =
            {
                new[] {1, 1, 1, 0, 0, 0},
                new[] {0, 1, 0, 0, 0, 0},
                new[] {1, 1, 1, 0, 0, 0},
                new[] {0, 0, 2, 4, 4, 0},
                new[] {0, 0, 0, 2, 0, 0},
                new[] {0, 0, 1, 2, 4, 0}
            };
            //act
            int sum = HourglassSum(testArray);

            //assert
            sum.Should().Be(19);
        }

        private int HourglassSum(int[][] hourglassArray)
        {
            List<int> allSums = new List<int>();

            for (int currentOutsideIndex = 0; currentOutsideIndex < hourglassArray.Length - 2; currentOutsideIndex++)
            {
                for (int currentIndex = 0;
                    currentIndex < hourglassArray[currentOutsideIndex].Length - 2;
                    currentIndex++)
                {
                    allSums.Add(GetHourglassLineSum(hourglassArray[currentOutsideIndex], currentIndex) +
                                GetHourglassLineSum(hourglassArray[currentOutsideIndex + 1], currentIndex, true) +
                                GetHourglassLineSum(hourglassArray[currentOutsideIndex + 2], currentIndex));
                }
            }

            return allSums.Max();
        }

        private int GetHourglassLineSum(int[] lineArray, int currentIndex, bool isMiddleLine = false)
        {
            if (isMiddleLine) return lineArray[currentIndex + 1];
            return lineArray[currentIndex] + lineArray[currentIndex + 1] + lineArray[currentIndex + 2];
        }
    }
}