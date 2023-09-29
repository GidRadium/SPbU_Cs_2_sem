using Task_01_Sorting;

public class Tests
{
    [Test]
    public void Test1()
    {
        int[] array = { 5, 3, 1, 4, 2 };
        int[] sortedArray = Sorting.BubbleSort(array);
        
        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void Test2()
    {
        int[] array = { };
        int[] sortedArray = Sorting.BubbleSort(array);

        Assert.That(sortedArray, Is.Empty);
    }

    [Test]
    public void Test3()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] sortedArray = Sorting.BubbleSort(array);

        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void Test4()
    {
        int[] array = { 5, 3, 1, 4, 2, 4 };
        int[] sortedArray = Sorting.BubbleSort(array);

        Assert.That(sortedArray, Is.EqualTo(new int[] { 1, 2, 3, 4, 4, 5 }));
    }
}
