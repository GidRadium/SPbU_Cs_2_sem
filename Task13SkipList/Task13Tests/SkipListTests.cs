using Task13SkipList;
namespace Task13Tests;
public class SkipListTests
{
    SkipList<int> list;

    [SetUp]
    public void Setup()
    {
        list = new SkipList<int>();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
