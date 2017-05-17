using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class PlusMinus
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldCountPositiveNumbers()
        {
            //assign
            int[] arr = new[] {-4, 3, -9, 0, 4, 1};
            //act
            int positiveNumberCount = CountPositiveNumbers(arr);
            //assert
            positiveNumberCount.Should().Be(3);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldCountNegativeNumbers()
        {
            //assign
            int[] arr = new[] { -4, 3, -9, 0, 4, 1 };
            //act
            int negativeNumberCount = CountNegativeNumbers(arr);
            //assert
            negativeNumberCount.Should().Be(2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldCountWhereNumberIsZero()
        {
            //assign
            int[] arr = new[] { -4, 3, -9, 0, 4, 1 };
            //act
            int negativeNumberCount = CountZeros(arr);
            //assert
            negativeNumberCount.Should().Be(1);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldGetPercentageOfPositive()
        {
            //assign
            int[] arr = new[] { -4, 3, -9, 0, 4, 1 };
            //act
            decimal positivePercentage = PositivePercentage(arr);
            //assert
            positivePercentage.Should().Be(0.500000M);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldGetPercentageOfNegative()
        {
            //assign
            int[] arr = new[] { -4, 3, -9, 0, 4, 1 };
            //act
            decimal positivePercentage = NegativePercentage(arr);
            //assert
            positivePercentage.Should().Be(0.333333M);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldGetPercentageOfZeros()
        {
            //assign
            int[] arr = new[] { -4, 3, -9, 0, 4, 1 };
            //act
            decimal zerosPercentage = PercentageOfZeros(arr);
            //assert
            zerosPercentage.Should().Be(0.166667M);
        }

        private static decimal PercentageOfZeros(int[] arr) => Math.Round((decimal)CountZeros(arr) / (decimal)arr.Length, 6);
        private static decimal NegativePercentage(int[] arr) => Math.Round((decimal)CountNegativeNumbers(arr) / (decimal)arr.Length,6);
        private static decimal PositivePercentage(int[] arr) => Math.Round((decimal)CountPositiveNumbers(arr) / (decimal)arr.Length,6);
        private static int CountZeros(int[] inputArray) => inputArray.Count(i => i == 0);
        private static int CountNegativeNumbers(int[] intputArray) => intputArray.Count(i => i < 0);
        private static int CountPositiveNumbers(int[] intputArray) => intputArray.Count(i => i > 0);
    }
}
