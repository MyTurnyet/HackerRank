using System;
using FluentAssertions;
using FluentAssertions.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep
{
    [TestClass]
    public class SockMerchant
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn2Pairs()
        {
            //assign
            int[] sockArray = new[] {1, 2, 1, 2, 1, 3, 2};
            
            //act
            int numberOfPairs = FindPairs(7, sockArray);

            //assert
            numberOfPairs.Should().Be(2);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn3Pairs()
        {
            //assign
            int[] sockArray = new[] {10,20,20,10,10,30,50,10,20};
            
            //act
            int numberOfPairs = FindPairs(7, sockArray);

            //assert
            numberOfPairs.Should().Be(3);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn4Pairs()
        {
            //assign
            int[] sockArray = new[] {1,1,3,1,2,1,3,3,3,3};
            
            //act
            int numberOfPairs = FindPairs(10, sockArray);

            //assert
            numberOfPairs.Should().Be(4);
        }

        private int FindPairs(int numberOfSocks, int[] ar)
        {
            Array.Sort(ar);
            int numberOfPairs = 0;
            for (int currentIndex = 0; currentIndex < ar.Length-1; currentIndex++) 
            {
                if (ar[currentIndex] != ar[currentIndex + 1]) continue;
                numberOfPairs++;
                currentIndex++;
            }

            return numberOfPairs;
        }
    }
}