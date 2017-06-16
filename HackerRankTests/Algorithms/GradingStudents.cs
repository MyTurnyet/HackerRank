using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class GradingStudents
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn29For29()
        {
            //act
            int actualReturnVal = RoundUp(29);
            //assert
            actualReturnVal.Should().Be(29);

        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldProcessIntArray()
        {
            //arrange
            int[] inputNumbers = new[] {73, 67, 38, 33};
            //act
            int[] outputArray = Solve(inputNumbers);
            //assert
            outputArray.Should().BeEquivalentTo(new int[] {75, 67, 40, 33});
        }

        private static int[] Solve(int[] inputNumbers)
        {
            List<int> outputArray = new List<int>();
            foreach (int inputNumber in inputNumbers)
            {
                outputArray.Add(RoundUp(inputNumber));
            }
            return outputArray.ToArray();
        }

        [TestCategory("Unit")]
        [DataTestMethod]
        [DataRow(73, 75)]
        [DataRow(67, 67)]
        [DataRow(38, 40)]
        [DataRow(33, 33)]
        public void ShouldRoundToNextHighestMultipleOfFive(int inputNumber, int expectedNumber)
        {
            //act
            int actualReturnVal = RoundUp(inputNumber);
            //assert
            actualReturnVal.Should().Be(expectedNumber);

        }

        private static int RoundUp(int inputNumber)
        {
            int returnVal = inputNumber;
            if (Padding(inputNumber) < 3)
            {
                returnVal += Padding(inputNumber);
            }
            return returnVal < 40 ? inputNumber : returnVal;
        }

        private static int Padding(int inputNumber) => 5 - (inputNumber % 5);
    }
}
