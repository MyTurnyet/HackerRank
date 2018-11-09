using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep
{
    [TestClass]
    public class JumpingClouds
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldJumpClouds_2and5_with_4jumps()
        {
            //assign
            int[] path = new[] {0, 0, 1, 0, 0, 1, 0};
            //act
            int minimumJumps = jumpingOnClouds(path);
            //assert
            minimumJumps.Should().Be(4);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldJumpCloud_5_with_3jumps()
        {
            //assign
            int[] path = new[] {0, 0, 0, 1, 0, 0};
            //act
            int minimumJumps = jumpingOnClouds(path);
            //assert
            minimumJumps.Should().Be(3);
        }

        private int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            for (int currentCloud = 0; currentCloud < c.Length-1; currentCloud++)
            {
                jumps++;
                if (currentCloud < c.Length-2 && c[currentCloud + 2] == 0) currentCloud++;
            }

            return jumps;
        }
    }
}