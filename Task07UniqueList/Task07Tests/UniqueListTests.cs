namespace Task07Tests;
using Task07UniqueList;

public class UniqueListTests
{
    private UniqueList list = new UniqueList();

    [Test]
    public void T1UniqueListAddDublicateElementThrowsException1()
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
    public void T2UniqueListAddDublicateElementThrowsException2()
    {
        list.AddValue(9, 0);
        list.SetValue(9, 0);

        Assert.That(() => list.AddValue(9, 1), Throws.Exception.TypeOf<AddRepeatingElementToUniqueListException>());
    }
}