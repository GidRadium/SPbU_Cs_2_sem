using Task04StackCalculator;
namespace Task04Tests;

[TestFixture]
public class StackCalculatorTests
{
    private static IEnumerable<TestCaseData> Calculators
        => new TestCaseData[]
        {
            new TestCaseData(new StackCalculator(new ArrayStack())),
            new TestCaseData(new StackCalculator(new ListStack())),
        };

    [TestCaseSource(nameof(Calculators))]
    public void Test1(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("1 1 +"), Is.EqualTo(2));

    [TestCaseSource(nameof(Calculators))]
    public void Test2(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("9 4 2 * +"), Is.EqualTo(17));

    [TestCaseSource(nameof(Calculators))]
    public void Test3(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("0 0 0 0 + * -"), Is.EqualTo(0));

    [TestCaseSource(nameof(Calculators))]
    public void Test4(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("5 2 /"), Is.EqualTo(2.5).Within(StackCalculator.Delta));

    [TestCaseSource(nameof(Calculators))]
    public void Test5(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 0 /"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void Test6(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 1 1 - /"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void Test7(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 1 1 -"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void Test8(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 1 - *"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void Test9(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 a -"), Throws.Exception);
}
