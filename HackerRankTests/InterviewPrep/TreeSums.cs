using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.InterviewPrep
{
    [TestClass]
    public class TreeSums
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchTotalSum()
        {
            //assign
            Node node = new Node(10);

            //act
            bool sumMatches = node.SumMatches(10);
            //assert
            sumMatches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchTotalSumWithSingleBranch()
        {
            //assign
            Node childNode = new Node(5);
            Node node = new Node(10, new[] {childNode});

            //act
            bool sumMatches = node.SumMatches(15);
            //assert
            sumMatches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchTotalSumWithTwoBranches()
        {
            //assign
            Node childNode2 = new Node(5);
            Node childNode1 = new Node(3);
            Node node = new Node(10, new[] {childNode1, childNode2});

            //act
            bool sumMatches = node.SumMatches(15);
            //assert
            sumMatches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchTotalSumWithFourBranches()
        {
            //assign
            Node childNode21 = new Node(8);
            Node childNode11 = new Node(1);
            Node childNode2 = new Node(5, new[] {childNode11, childNode21});
            Node childNode1 = new Node(3);
            Node node = new Node(10, new[] {childNode1, childNode2});

            //act
            bool sumMatches = node.SumMatches(23);
            //assert
            sumMatches.Should().BeTrue();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatchTotalSumWithSingleBranch()
        {
            //assign
            Node childNode = new Node(5);
            Node node = new Node(10, new[] {childNode});

            //act
            bool sumMatches = node.SumMatches(18);
            //assert
            sumMatches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatchTotalSumWithTwoBranches()
        {
            //assign
            Node childNode1 = new Node(5);
            Node childNode2 = new Node(5);
            Node node = new Node(10, new[] {childNode1, childNode2});

            //act
            bool sumMatches = node.SumMatches(18);
            //assert
            sumMatches.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatchTotalSum()
        {
            //assign
            Node node = new Node(10);

            //act
            bool sumMatches = node.SumMatches(21);
            //assert
            sumMatches.Should().BeFalse();
        }


        private class Node
        {
            private readonly int _value;
            private readonly Node[] _childNodes;

            public Node(int value, Node[] childNodes)
            {
                _value = value;
                _childNodes = childNodes;
            }

            public Node(int value) : this(value, new Node[0])
            {
            }

            public bool SumMatches(int numberToMatch)
            {
                if (numberToMatch < _value) return false;
                if (numberToMatch == _value) return true;

                return _childNodes.Aggregate(false,
                    (current, childNode) => current || childNode.SumMatches(numberToMatch - _value));
            }
        }
    }
}