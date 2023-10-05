namespace Task_07_Tests;
using Task_07_UniqueList;

public class TestMyList
{
    private MyList list = new MyList();

    [Test]
    public void Test1() => Assert.That(list.Size, Is.EqualTo(0));

    [Test]
    public void Test2() => Assert.That(list.Contains(0), Is.False);

    [Test]
    public void Test3()
    {
        list.AddValue(0, 0);
        list.AddValue(1, 1);
        list.AddValue(2, 2);
        list.AddValue(3, 3);
        list.DeleteValue(0);
        Assert.That(list.Size, Is.EqualTo(3));
    }

    [Test]
    public void Test4()
    {
        list.SetValue(4, 0);
        Assert.That(list.GetValue(0), Is.EqualTo(4));
    }

    [Test]
    public void Test5()
    {
        list.SetValue(4, 0);
        Assert.That(list.GetValue(0), Is.EqualTo(4));
    }

    [Test]
    public void Test6()
    {
        Assert.That(() => list.SetValue(3, 3), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
    }
}

public class TestUniqueList
{
    private UniqueList list = new UniqueList();

    [Test]
    public void Test1()
    {
        list.AddValue(0, 0);
        list.AddValue(1, 1);
        list.AddValue(2, 2);
        list.AddValue(3, 3);
        list.DeleteValue(0);
        list.AddValue(0, 3);

        Assert.That(() => list.AddValue(3, 1), Throws.Exception.TypeOf<AddRepeatingElementToUniqueListException>());
    }

    [Test]
    public void Test2()
    {
        list.AddValue(9, 0);
        list.SetValue(9, 0);

        Assert.That(() => list.AddValue(9, 1), Throws.Exception.TypeOf<AddRepeatingElementToUniqueListException>());
    }
}
