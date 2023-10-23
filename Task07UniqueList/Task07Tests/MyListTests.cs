namespace Task07Tests;
using Task07UniqueList;

public class MyListTests
{
    private MyList list = new MyList();

    [Test]
    public void T1MyListStartSizeReturnsZero() => Assert.That(list.Size, Is.EqualTo(0));

    [Test]
    public void T2MyListEmptyListDontContainsZero() => Assert.That(list.Contains(0), Is.False);

    [Test]
    public void T3MyListSizeWorkingCorrectly()
    {
        list.AddValue(0, 0);
        list.AddValue(1, 1);
        list.AddValue(2, 2);
        list.AddValue(3, 3);
        list.DeleteValue(0);
        Assert.That(list.Size, Is.EqualTo(3));
    }

    [Test]
    public void T4MyListSetAndGetValueAreCorrect1()
    {
        list.SetValue(4, 0);
        Assert.That(list.GetValue(0), Is.EqualTo(4));
    }

    [Test]
    public void T5MyListSetAndGetValueAreCorrect2()
    {
        list.SetValue(4, 0);
        Assert.That(list.GetValue(0), Is.EqualTo(4));
    }

    [Test]
    public void T6MyListSetOutOfRangeThrowsException()
        => Assert.That(() => list.SetValue(3, 3), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
}
