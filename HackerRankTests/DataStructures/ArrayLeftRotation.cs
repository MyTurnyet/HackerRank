using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.DataStructures
{
    [TestClass]
    public class ArrayLeftRotation
    {
/*        [TestMethod, TestCategory("Unit")]
        public void ShouldRotateLeftOneSpace()
        {
            //assign
            int[] testArray = new[] {1, 2, 3, 4, 5};

            //act
            int[] rotatedArray = RotateArray(testArray, 4);
            //assert
            rotatedArray.Should().ContainInOrder(new[] {5, 1, 2, 3, 4});
        }*/

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

        private int[] RotateArray(int[] arrayToRotate, int numberOfShifts)
        {
            List<int> outputList = new List<int>();
            int arrayLength = arrayToRotate.Length;
            for (int index = 0; index < arrayLength; index++)
            {
                var currentIndex = CurrentIndex(numberOfShifts, index, arrayLength);
                outputList.Add(arrayToRotate[currentIndex]);
            }

            return outputList.ToArray();
        }

        private int CurrentIndex(int numberOfShifts, int index, int arrayLength)
        {
            return numberOfShifts + index > arrayLength - 1 ? 0 : numberOfShifts + index;
        }
    }
}