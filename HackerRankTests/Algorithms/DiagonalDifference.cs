using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Algorithms
{
    [TestClass]
    public class DiagonalDifference
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public int main()
        {
            var n = int.Parse(Console.ReadLine());
            var suma = 0;
            int sumb = 0;
            for (var i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                suma += int.Parse(line[i]);
                sumb += int.Parse(line[n - i - 1]);
            }
            Console.WriteLine(Math.Abs(sumb - suma));
        }
    }
}
