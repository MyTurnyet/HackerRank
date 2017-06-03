using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class BirthdayCakeCandles
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHighestCandles()
        {
            //assign
            int[] inputArr = new[] { 3, 2, 1, 3 };
            //act
            int highest = GetHighest(inputArr);
            //assert
            highest.Should().Be(3);

        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldCountHighestCandles()
        {
            //assign
            int[] inputArr = new[] { 3, 2, 1, 3 };
            //act
            int highest = CountHighest(inputArr);
            //assert
            highest.Should().Be(2);

        }

        private static int highestCandle = 0;
        private static int CountHighest(int[] inputArr)=>inputArr.Count(candle => candle == GetHighest(inputArr));
        private static int GetHighest(int[] inputArr)
        {
            if (highestCandle > 0) return highestCandle;
            highestCandle = inputArr.Max();
            return highestCandle;

        }
    }
}
