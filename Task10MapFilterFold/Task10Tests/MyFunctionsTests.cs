using Task10MapFilterFold;
namespace Task10Tests;

public class MyFunctionsTests
{
    [Test]
    public void MyFunctionsMapReturnsCorrectResult()
        => CollectionAssert.AreEqual(MyFunctions.Map(new List<int>() { 1, 2, 3 }, x => x * 2), new List<int>() { 2, 4, 6 });

    [Test]
    public void MyFunctionsFilterReturnsCorrectResult()
        => CollectionAssert.AreEqual(MyFunctions.Filter(new List<int>() { -2, -1, 0, 1, 2, 3, 4, 5 }, x => x <= 0), new List<int>() { -2, -1, 0 });

    [Test]
    public void MyFunctionsFoldReturnsCorrectResult()
        => Assert.That(MyFunctions.Fold(new List<int>() { 1, 2, 3, 4, 5 }, 1, (value, element) => value * element), Is.EqualTo(120));

    [Test]
    public void MyFunctionsFilterLettersIsCorrect()
        => CollectionAssert.AreEqual(MyFunctions.Filter(new List<char>() { 'a', 'b', '\n', 'c', '\n', '\n', 'd', ' ', '\n' }, x => x != '\n' && x != ' '), new List<int>() { 'a', 'b', 'c', 'd' });
}
