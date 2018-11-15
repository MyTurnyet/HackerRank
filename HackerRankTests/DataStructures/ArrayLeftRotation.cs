using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.DataStructures
{
    [TestClass]
    public class ArrayLeftRotation
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldRotateLeftOneSpace()
        {
            //assign
            int[] testArray = new[] {1, 2, 3, 4, 5};

            //act
            int[] rotatedArray = RotateArray(testArray, 4);
            //assert
            rotatedArray.Should().ContainInOrder(new[] {5, 1, 2, 3, 4});
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldRotateLeftOneSpace_EndingWith2()
        {
            //assign
            int[] testArray = new[] {2, 3, 4, 5, 1};

            //act
            int[] rotatedArray = RotateArray(testArray, 1);
            string output = string.Join(" ", rotatedArray);
            //assert
            output.Should().Be("3 4 5 1 2");
            rotatedArray.Should().ContainInOrder(new[] {3, 4, 5, 1, 2});
        }

        private int[] RotateArray(int[] a, int d)
        {
            List<int> outputList = new List<int>();
            int arrayLength = a.Length;
            for (int index = 0; index < arrayLength; index++)
            {
                var currentIndex = CurrentIndex(d, index, arrayLength);
                outputList.Add(a[currentIndex]);
            }

            return outputList.ToArray();
        }

        private int CurrentIndex(int numberOfShifts, int arrayIndex, int arrayLength)
        {
            return numberOfShifts + arrayIndex > arrayLength - 1
                ? (numberOfShifts - arrayLength) + arrayIndex
                : numberOfShifts + arrayIndex;
        }
    }
}