using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep
{
    [TestClass]
    public class RansomNote
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchAllWordsInNoteArray()
        {
            //assign
            string[] magazine = new[] {"give", "me", "one", "grand", "today", "night"};
            string[] note = new[] {"give", "one", "grand", "today"};
            //act
            bool wordsMatch = checkMagazine(magazine, note);
            //assert
            wordsMatch.Should().BeTrue();
        }

        private bool checkMagazine(string[] magazine, string[] note)
        {
            foreach (string word in note)
            {
                if (note.All(match => match != word)) return false;
            }
            return true;
        }
    }
}