using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class StairCase
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldWriteOutOneLevel()
        {
            //assign
            int inputNumber = 1;
            //act
            string output = GetStaircase(inputNumber);
            //assert
            output.Should().Be("#");
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldWriteOutTwoLevels()
        {
            //assign
            int inputNumber = 2;
            //act
            string output = GetStaircase(inputNumber);
            //assert
            output.Should().Be(" #\r\n##");
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldWriteOutFourLevels()
        {
            //assign
            int inputNumber = 4;
            //act
            string output = GetStaircase(inputNumber);
            //assert
            output.Should().Be("   #\r\n  ##\r\n ###\r\n####");
        }

        private string GetStaircase(int inputNumber)
        {
            string output = String.Empty;
            for (int i = 0; i < inputNumber; i++)
            {
                output += $"{"".PadLeft(i + 1, '#').PadLeft(inputNumber, ' ')}{(i < inputNumber - 1 ? "\r\n" : string.Empty)}";
            }
            return output;
        }
    }
}
