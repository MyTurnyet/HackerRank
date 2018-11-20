using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep
{
    [TestClass]
    public class MinimumSwaps
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn5Jumps()
        {
            //assign
            int[] arrayToSort = new[] {7, 1, 3, 2, 4, 5, 6};

            //act
            int jumps = SortArray(arrayToSort);
            //assert
            jumps.Should().Be(5);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn4Jumps()
        {
            //assign
            int[] arrayToSort = new[] {4, 3, 1, 2};

            //act
            int jumps = SortArray(arrayToSort);
            //assert
            jumps.Should().Be(3);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn3JumpsForArrayOf5()
        {
            //assign
            int[] arrayToSort = new[] {2, 3, 4, 1, 5};

            //act
            int jumps = SortArray(arrayToSort);
            //assert
            jumps.Should().Be(3);
        }

        private int SortArray(int[] arrayToSort, int currentIndex = 0, int jumpCount = 0)
        {
            if (currentIndex == arrayToSort.Length - 1) return jumpCount;
            if (arrayToSort[currentIndex] != currentIndex + 1)
            {
                int valueAtIndex = arrayToSort[currentIndex];
                int valueAtActualPosition = arrayToSort[valueAtIndex - 1];
                arrayToSort[currentIndex] = valueAtActualPosition;
                arrayToSort[valueAtIndex - 1] = valueAtIndex;
                jumpCount++;
            }
            else
            {
                currentIndex++;
            }

            return SortArray(arrayToSort, currentIndex, jumpCount);
        }
    }
}