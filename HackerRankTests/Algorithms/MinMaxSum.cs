using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class MinMaxSum
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldGetMinimumSum()
        {
            //assign
            Int64[] inputArray = { 1, 2, 3, 4, 5 };
            int expectedValue = 10;
            //act
            Int64 actualValue = CalculateMinimumSum(inputArray);
            //assert
            actualValue.Should().Be(expectedValue);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldGetMaximumSum()
        {
            //assign
            Int64[] inputArray = { 1, 2, 3, 4, 5 };
            int expectedValue = 14;
            //act
            Int64 actualValue = CalculateMaximumSum(inputArray);
            //assert
            actualValue.Should().Be(expectedValue);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldGetMaximumSumUnsorted()
        {
            //assign
            Int64[] inputArray = { 5, 4, 6, 3, 7 };
            int expectedValue = 22;
            //act
            Int64 actualValue = CalculateMaximumSum(inputArray);
            //assert
            actualValue.Should().Be(expectedValue);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldGetMinimumSumUnsorted()
        {
            //assign
            Int64[] inputArray = { 4, 2, 5, 3, 6 };
            int expectedValue = 14;
            //act
            Int64 actualValue = CalculateMinimumSum(inputArray);
            //assert
            actualValue.Should().Be(expectedValue);
        }

        private Int64 CalculateMinimumSum(Int64[] inputArray)
        {
            List<Int64> arrList = new List<Int64>(inputArray);
            arrList.Sort();
            Int64 output = 0;
            for (int i = 0; i < 4; i++)
            {
                output += arrList[i];
            }
            return output;
        }
        private Int64 CalculateMaximumSum(Int64[] inputArray)
        {
            List<Int64> arrList = new List<Int64>(inputArray);
            arrList.Sort();
            Int64 output = 0;
            for (int i = 1; i <= 4; i++)
            {
                output += arrList[i];
            }
            return output;
        }

    }
}
