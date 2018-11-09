using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep
{
    [TestClass]
    public class CountingValleys
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldCountOneValley()
        {
            //assign
            string stepsTaken = "UDDDUDUU";
            int numberOfSteps = 8;

            //act
            int totalValleys = countingValleys(numberOfSteps, stepsTaken);
            //assert
            totalValleys.Should().Be(1);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldTwoValleys()
        {
            //assign
            string stepsTaken = "DDUUDDDUUU";
            int numberOfSteps = 10;

            //act
            int totalValleys = countingValleys(numberOfSteps, stepsTaken);
            //assert
            totalValleys.Should().Be(2);
        }
        
        [TestMethod, TestCategory("Unit")]
        public void ShouldOneLongValley()
        {
            //assign
            string stepsTaken = "DDDUUDDDUUUU";
            int numberOfSteps = 10;

            //act
            int totalValleys = countingValleys(numberOfSteps, stepsTaken);
            //assert
            totalValleys.Should().Be(1);
        }

        private int countingValleys(int numberOfSteps, string s)
        {
            int valleyCount = 0;
            int currentSpot = 0;
            foreach (char step in s)
            {
                if (currentSpot<0)
                {
                    currentSpot = StepToNextLevel(currentSpot, step);
                    if (currentSpot == 0)
                    {
                        valleyCount++;                        
                    }
                    continue;
                }
                currentSpot = StepToNextLevel(currentSpot, step);
            }

            return valleyCount;
        }

        private int StepToNextLevel(int currentSpot, char step)
        {
            return step == 'D' ? --currentSpot : ++currentSpot;
        }
    }
}