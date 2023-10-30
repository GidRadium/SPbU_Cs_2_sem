using Task13SkipList;
namespace Task13Tests;
public class SkipListTests
{
    SkipList<int> list;

    [SetUp]
    public void Setup()
        => list = new SkipList<int>();

    [Test]
    public void SkipListCountOfEmptyListReturnsZero()
        => Assert.That(list.Count, Is.EqualTo(0));

    [Test]
    public void SkipListIndexOfIsWorkingCorrectly1()
    {
        list[1] = 1;
        list[10] = 10;
        list[5] = 5;
        list[6] = 6;

        Assert.That(list.IndexOf(5), Is.EqualTo(5));
    }

    [Test]
    public void SkipListIndexOfIsWorkingCorrectly2()
    {
        list[1] = 1;
        list[10] = 10;
        list[5] = 5;
        list[6] = 6;

        Assert.That(list.IndexOf(4), Is.EqualTo(-1));
    }

    [Test]
    public void SkipListContainsIsWorkingCorrectly1()
    {
        list[1] = 1;
        list[10] = 10;
        list[5] = 5;
        list[6] = 6;

        Assert.That(list.Contains(4), Is.EqualTo(false));
    }

    [Test]
    public void SkipListContainsIsWorkingCorrectly2()
    {
        list[1] = 1;
        list[10] = 10;
        list[5] = 5;
        list[6] = 6;

        Assert.That(list.Contains(10), Is.EqualTo(true));
    }

    [Test]
    public void SkipListInsertInEmptyListIsCorrect()
    {
        list.Insert(0, 0);

        Assert.That(list[0], Is.EqualTo(0));
    }

    [Test]
    public void SkipListAddInEmptyListIsCorrect()
    {
        list.Add(0);
        list.Add(1);

        Assert.That(list[0], Is.EqualTo(0));
    }

    [Test]
    public void SkipListRemoveAtIsCorrect()
    {
        list.Add(0);
        list.RemoveAt(0);
        list.Add(1);

        Assert.That(list[0], Is.EqualTo(1));
    }


    [Test]
    public void SkipListCountOfListReturnsCorrectValue()
    {
        list.Add(0);
        list.Add(1);
        list[3] = 3;
        list.Insert(3, 2);
        list.RemoveAt(0);
        list.Insert(1, 1);

        Assert.That(list.Count, Is.EqualTo(2));
    }

    [Test]
    public void SkipListRemoveAtRemovesElementCorrectly()
    {
        list.Add(0);
        list.Add(1);
        list.Add(2);
        list.RemoveAt(0);
        list.RemoveAt(1);
        list[0] = 0;
        
        Assert.That(list.Count, Is.EqualTo(2));
    }

    [Test]
    public void SkipListForEachIsWorking()
    {
        list.Add(0);
        list[1] = 1;
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Remove(4);
        list.RemoveAt(2);
        list.Insert(6, 6);

        int summ = 0;
        foreach (var item in list)
            summ += item;

        Assert.That(summ, Is.EqualTo(15));
    }

    [Test]
    public void SkipListClearClearsList()
    {
        list.Insert(0, 0);
        list[1] = 1;
        list[10] = 10;
        list.Add(11);

        list.Clear();
        
        list.Add(0);

        Assert.That(list.Count, Is.EqualTo(1));
    }

    [Test]
    public void SkipListCopyToIsCorrect()
    {
        list[0] = 0;
        list[5] = 5;
        list[10] = 10;
        list[100] = 100;
        list[7] = 7;
        var array = new int[6];
        list.CopyTo(array, 1);
        
        Assert.That(array, Is.EquivalentTo(new List<int> { 0, 0, 5, 7, 10, 100 }));
    }
}
