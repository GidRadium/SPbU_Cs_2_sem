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
    public void StackCalculatorOnePlusOneReturnsTwo(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("1 1 +"), Is.EqualTo(2));

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorStandartStringReturnsSeventeen(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("9 4 2 * +"), Is.EqualTo(17));

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorZeroesReturnsZero(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("0 0 0 0 + * -"), Is.EqualTo(0));

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorDivisionIsCorrect(StackCalculator stackCalculator)
        => Assert.That(stackCalculator.Solve("5 2 /"), Is.EqualTo(2.5).Within(StackCalculator.Delta));

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorDivisionByZeroReturnsException1(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 0 /"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorDivisionByZeroReturnsException2(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 1 1 - /"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorIncorrectStringReturnsException1(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 1 1 -"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorIncorrectStringReturnsException2(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 1 - *"), Throws.Exception);

    [TestCaseSource(nameof(Calculators))]
    public void StackCalculatorIncorrectStringReturnsException3(StackCalculator stackCalculator)
        => Assert.That(() => stackCalculator.Solve("1 a -"), Throws.Exception);
}
