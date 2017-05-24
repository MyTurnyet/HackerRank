using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class TimeConversion
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldConvert12HourTimeTo24HourTime()
        {
            //assign
            string startTime = "07:05:45PM";

            //act
            DateTime timeObj = DateTime.Parse(startTime);
            //assert
            DateTime.Parse(startTime).ToString("HH:mm:ss").Should().Be("19:05:45");
        }

    }
}
