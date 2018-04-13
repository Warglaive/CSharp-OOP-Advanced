using System.Collections.Generic;
using BubbleSort;
using NUnit.Framework;

namespace BubbleSortTests
{
    public class Tests
    {
        [Test]
        public void NegativeNumbersSort()
        {
            //sort ascending
            var expectedList = new List<int> { -4, -3, -2, -1, 0 };
            var negativeNumbersList = new List<int>();
            for (int i = 0; i > -5; i--)
            {
                negativeNumbersList.Add(i);
            }
            var bubbleSort = new Bubble(negativeNumbersList);

            bubbleSort.Sort();
            var sortedList = bubbleSort.integersToSort;

            Assert.AreEqual(sortedList, expectedList);
        }

        [Test]
        public void MultipleZeroDigitsSort()
        {
            var multipleZeroList = new List<int> { 0, 9, 8, 7, 0, 6, 5, 0, 4, 3, 2, 0, 1, 0 };
            var expectedResult = new List<int> { 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var bubble = new Bubble(multipleZeroList);
            bubble.Sort();
            var result = bubble.integersToSort;
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void IntHighValuesSortTest()
        {
            var lowestBiggerValue = int.MaxValue - 10000;
            //
            var mediumBiggerValue = int.MaxValue - 1000;
            //
            var highestBiggerValue = int.MaxValue - 100;

            var list = new List<int> { highestBiggerValue, mediumBiggerValue, lowestBiggerValue };
            var expectedResult = new List<int> { lowestBiggerValue, mediumBiggerValue, highestBiggerValue };
            var bubble = new Bubble(list);
            bubble.Sort();
            var result = bubble.integersToSort;
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [SetUp]
        public void CustomNumbersTest()
        {
            var expectedResult = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var toBeSorted = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var bubble = new Bubble(toBeSorted);
            bubble.Sort();
            var result = bubble.integersToSort;
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void CharactersSortTest()
        {
            var expectedResult = new List<int> { 'a', 'b', 'c' };
            var toBeSorted = new List<int> { 'c', 'a', 'b' };
            var bubble = new Bubble(toBeSorted);
            bubble.Sort();
            var result = bubble.integersToSort;
            Assert.AreEqual(result, expectedResult);
        }
    }
}