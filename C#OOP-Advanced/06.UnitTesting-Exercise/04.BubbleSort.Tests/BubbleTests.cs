using NUnit.Framework;

namespace _04.BubbleSort.Tests
{
    [TestFixture]
    public class BubbleTests
    {
        [Test]
        [TestCase(1, 2, 3, 4, 5, 6, 7, 9, 8)]
        [TestCase(9, 1, 2, 3, 4, 8, 7, 6, 5)]
        public void BubbleCanSortNumbers(params int[] numbersToSort)
        {
            // Arrange
            var bubble = new Bubble();
            var sortedNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            bubble.Sort(numbersToSort);

            // Assert
            CollectionAssert.AreEqual(sortedNumbers, numbersToSort);
        }
    }
}
