using Task01Sorting;

public class BubbleSortTests
{
    [Test]
    public void BubbleSortStandartArrayReturnsSortedArray()
    {
        int[] array = { 5, 3, 1, 4, 2 };
        int[] sortedArray = Sorting.BubbleSort(array);
        
        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void BubbleSortEmptyArrayReturnsEmptyArray()
    {
        int[] array = { };
        int[] sortedArray = Sorting.BubbleSort(array);

        Assert.That(sortedArray, Is.Empty);
    }

    [Test]
    public void BubbleSortSortedArrayReturnsSortedArray()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] sortedArray = Sorting.BubbleSort(array);

        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void BubbleSortDublicatedArrayElementsReturnsSortedArray()
    {
        int[] array = { 5, 3, 1, 4, 2, 4 };
        int[] sortedArray = Sorting.BubbleSort(array);

        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 4, 5 }));
    }
}
