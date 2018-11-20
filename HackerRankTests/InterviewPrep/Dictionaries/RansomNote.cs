using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep.Dictionaries
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
            bool wordsMatch = parseWords(magazine, note);
            //assert
            wordsMatch.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatchAllWordsInNoteArray()
        {
            //assign
            string[] magazine = new[] {"two", "times", "three", "is", "not", "four", "is"};
            string[] note = new[] {"two", "times", "two", "is", "four"};
            //act
            bool wordsMatch = parseWords(magazine, note);
            //assert
            wordsMatch.Should().BeFalse();
        }

        private bool parseWords(string[] magazine, string[] note)
        {
            Dictionary<string, int> magazineDictionary = CreateDictionary(magazine);
            Dictionary<string, int> noteDictionary = CreateDictionary(note);

            foreach (KeyValuePair<string, int> wordEntry in noteDictionary)
            {
                if (!magazineDictionary.ContainsKey(wordEntry.Key) ||
                    (magazineDictionary[wordEntry.Key] < wordEntry.Value)) return false;
            }

            return true;
        }

        private Dictionary<string, int> CreateDictionary(string[] arrayToConvert)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in arrayToConvert)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, 1);
                    continue;
                }

                dictionary[word]++;
            }

            return dictionary;
        }
    }
}