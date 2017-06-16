using System;
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
        private int RoundUp(int inputNumber)
        {
            int padding = Padding(inputNumber);
            int returnVal = inputNumber;
            if (padding < 3)
            {
                returnVal += padding;
            }
            return returnVal < 40 ? inputNumber : returnVal;
        }

        private int Padding(int inputNumber)
        {
            return 5 - (inputNumber % 5);
        }
    }
}
