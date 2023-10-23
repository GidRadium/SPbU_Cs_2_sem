namespace Task06Tests;
using Task06ParseTree;

public class ParseTreeTests
{
    [Test]
    public void ParseTreeStandartStringReturns4()
        => Assert.That(new ParseTree("(* (+ 1 1) 2)").Calculate(), Is.EqualTo(4));

    [Test]
    public void ParseTreeDivisionByZeroThrowsException()
        => Assert.That(() => new ParseTree("(/ (+ 1 1) (- 1 1))").Calculate(), Throws.Exception.TypeOf<DivideByZeroException>());

    [Test]
    public void ParseTreeStandartStringReturns15()
        => Assert.That(new ParseTree("(* (+ 1 2) (/ 10 (- 9 7)))").Calculate(), Is.EqualTo(15));

    [Test]
    public void ParseTreeIncorrectStringThrowsException1()
        => Assert.That(() => new ParseTree("(* (+ 1 2) (/ 10 (- 9)))"), Throws.Exception.TypeOf<IncorrectExpressionException>());
    
    [Test]
    public void ParseTreeIncorrectStringThrowsException2()
        => Assert.That(() => new ParseTree(""), Throws.Exception.TypeOf<IncorrectExpressionException>());
    
    [Test]
    public void ParseTreeIncorrectStringThrowsException3()
        => Assert.That(() => new ParseTree("()"), Throws.Exception.TypeOf<IncorrectExpressionException>());

    [Test]
    public void ParseTreeIncorrectStringThrowsException4()
        => Assert.That(() => new ParseTree("(1)"), Throws.Exception.TypeOf<IncorrectExpressionException>());

    [Test]
    public void ParseTreeOneNumberStringReturnsSameNumber()
        => Assert.That(new ParseTree("1").Calculate(), Is.EqualTo(1));

    [Test]
    public void ParseTreeToStringReturnsCorrectTree()
        => Assert.That(new ParseTree("(* (+ 1 2) (/ 10 (- 9 7)))").ToString(), Is.EqualTo("(* (+ 1 2) (/ 10 (- 9 7)))"));
}
