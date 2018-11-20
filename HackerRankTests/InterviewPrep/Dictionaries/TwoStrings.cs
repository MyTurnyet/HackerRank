using System.Collections;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep.Dictionaries
{
    [TestClass]
    public class TwoStrings
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnFalseForMatchingStrings()
        {
            //assign
            string hello = "hello";
            string pig = "pig";
            //act
            string actualOutput = twoStrings(hello, pig);
            //assert
            actualOutput.Should().Be("NO");
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnYesForMatchingStrings()
        {
            //assign
            string hello = "hello";
            string pig = "yelling";
            //act
            string actualOutput = twoStrings(hello, pig);
            //assert
            actualOutput.Should().Be("YES");
        }
        private string twoStrings(string s1, string s2)
        {
            Hashtable hashOfFirstString = new Hashtable();
            foreach (char c in s1)
            {
                if (!hashOfFirstString.ContainsKey(c))
                {
                    hashOfFirstString.Add(c,1);
                }

                if (hashOfFirstString.Count >= 26) return "YES";
            }

            foreach (char secondWordChar in s2)
            {
                if (hashOfFirstString.ContainsKey(secondWordChar)) return "YES";
            }

            return "NO";
        }
    }
}