namespace Task12Tests;
using Task12Calculator;
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void CalculatorOnePlusTwoIsThree()
    {
        calculator.EnterNumber(1);
        calculator.EnterOperation(Calculator.Operation.Plus);
        calculator.EnterNumber(2);
        Assert.That(calculator.Equals(), Is.EqualTo("3"));
    }

    [Test]
    public void CalculatorAfterSecondOperationReturnsResult()
    {
        calculator.EnterNumber(1);
        calculator.EnterOperation(Calculator.Operation.Plus);
        calculator.EnterNumber(2);
        calculator.EnterNumber(9);
        Assert.That(calculator.EnterOperation(Calculator.Operation.Multiply), Is.EqualTo("30 * "));
    }

    [Test]
    public void CalculatorDivisionIsCorrect()
    {
        calculator.EnterNumber(1);
        calculator.EnterOperation(Calculator.Operation.Divide);
        calculator.EnterNumber(2);
        Assert.That(calculator.Equals(), Is.EqualTo("0,5"));
    }

    [Test]
    public void CalculatorMultiplicationIsCorrect()
    {
        calculator.EnterNumber(3);
        calculator.EnterNumber(2);
        calculator.EnterOperation(Calculator.Operation.Multiply);
        calculator.EnterNumber(3);
        calculator.EnterNumber(2);
        Assert.That(calculator.Equals(), Is.EqualTo("1024"));
    }

    [Test]
    public void CalculatorSubtractionIsCorrect()
    {
        calculator.EnterNumber(1);
        calculator.EnterNumber(2);
        calculator.EnterNumber(3);
        calculator.EnterNumber(4);
        calculator.EnterOperation(Calculator.Operation.Minus);
        calculator.EnterNumber(1);
        calculator.EnterNumber(2);
        calculator.EnterNumber(3);
        Assert.That(calculator.Equals(), Is.EqualTo("1111"));
    }

    [Test]
    public void CalculatorClearIsCorrect()
    {
        calculator.EnterNumber(1);
        calculator.EnterNumber(2);
        calculator.EnterNumber(3);
        calculator.EnterNumber(4);
        calculator.EnterOperation(Calculator.Operation.Minus);
        Assert.That(calculator.Clear(), Is.EqualTo(""));
    }
}
