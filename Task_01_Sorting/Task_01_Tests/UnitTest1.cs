using Task_01_Sorting;

[TestFixture]
public class SortingTests
{
    [Test]
    public void BubbleSort_SortsArrayInAscendingOrder()
    {
        // Arrange
        int[] array = { 5, 3, 1, 4, 2 };

        // Act
        int[] sortedArray = Sorting.BubbleSort(array);
        
        // Assert
        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void BubbleSort_ReturnsEmptyArrayIfInputIsEmpty()
    {
        // Arrange
        int[] array = { };

        // Act
        int[] sortedArray = Sorting.BubbleSort(array);

        // Assert
        Assert.That(sortedArray, Is.Empty);
    }

    [Test]
    public void BubbleSort_ReturnsSameArrayIfInputIsAlreadySorted()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };

        // Act
        int[] sortedArray = Sorting.BubbleSort(array);

        // Assert
        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void BubbleSort_SortsArrayWithDuplicateValues()
    {
        // Arrange
        int[] array = { 5, 3, 1, 4, 2, 4 };

        // Act
        int[] sortedArray = Sorting.BubbleSort(array);

        // Assert
        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 4, 5 }));
    }
}
