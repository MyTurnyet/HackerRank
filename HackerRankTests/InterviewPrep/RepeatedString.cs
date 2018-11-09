using System;
using System.Linq;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep
{
    [TestClass]
    public class RepeatedString
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn100000()
        {
            //assign
            string infiniteString = "a";
            long characterCount = 1000000000000;
            //act
            long numberOfOccupancies = repeatedString(infiniteString, characterCount);
            //assert
            numberOfOccupancies.Should().Be(1000000000000);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturn7()
        {
            //assign
            string infiniteString = "aba";
            long characterCount = 10;
            //act
            long numberOfOccupancies = repeatedString(infiniteString, characterCount);
            //assert
            numberOfOccupancies.Should().Be(7);
        }

        private long repeatedString(string s, long characterCount)
        {
            long timeIntoLength = (characterCount / s.Length);
            int remainder = (int) (characterCount % s.Length);
            int numberOfA = s.Count(letter => letter == 'a');
            long stringCount = (timeIntoLength * numberOfA);
            
            for (int currentIndex = 0; currentIndex < remainder; currentIndex++)
            {
                if (s[currentIndex] == 'a') stringCount++;
            }

            return stringCount;
        }
    }
}