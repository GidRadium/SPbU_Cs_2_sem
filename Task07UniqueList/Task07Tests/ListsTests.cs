namespace Task07Tests;

using Task07UniqueList;

internal class ListsTests
{
    private static IEnumerable<TestCaseData> Lists
        => new TestCaseData[]
        {
            new TestCaseData(new MyList()),
            new TestCaseData(new UniqueList())
        };

    [TestCaseSource(nameof(Lists))]
    public void ListStartSizeReturnsZero(MyList list)
        => Assert.That(list.Size, Is.EqualTo(0));

    public void ListEmptyListDontContainsZero(MyList list)
        => Assert.That(list.Contains(0), Is.False);

    [TestCaseSource(nameof(Lists))]
    public void ListSizeWorkingCorrectly(MyList list)
    {
        list.AddValue(0, 0);
        list.AddValue(1, 1);
        list.AddValue(2, 2);
        list.AddValue(3, 3);
        list.DeleteValue(0);
        Assert.That(list.Size, Is.EqualTo(3));
    }

    [TestCaseSource(nameof(Lists))]
    public void ListSetAndGetValueAreCorrect(MyList list)
    {
        list.AddValue(0, 0);
        list.SetValue(4, 0);
        Assert.That(list.GetValue(0), Is.EqualTo(4));
    }

    [TestCaseSource(nameof(Lists))]
    public void ListSetTwiceAndGetValueAreCorrect(MyList list)
    {
        list.AddValue(0, 0);
        list.SetValue(4, 0);
        list.SetValue(4, 0);
        Assert.That(list.GetValue(0), Is.EqualTo(4));
    }

    [TestCaseSource(nameof(Lists))]
    public void ListSetOutOfRangeThrowsException(MyList list)
        => Assert.That(() => list.SetValue(3, 3), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

    [Test]
    public void UniqueListAddDublicateElementAfterDeleteThrowsException()
    {
        var list = new UniqueList();

        list.AddValue(0, 0);
        list.AddValue(1, 1);
        list.AddValue(2, 2);
        list.AddValue(3, 3);
        list.DeleteValue(0);
        list.AddValue(0, 3);

        Assert.That(() => list.AddValue(3, 1), Throws.Exception.TypeOf<AddRepeatingElementToUniqueListException>());
    }

    [Test]
    public void UniqueListAddDublicateElementThrowsException()
    {
        var list = new UniqueList();

        list.AddValue(9, 0);
        list.SetValue(9, 0);

        Assert.That(() => list.AddValue(9, 1), Throws.Exception.TypeOf<AddRepeatingElementToUniqueListException>());
    }
}
