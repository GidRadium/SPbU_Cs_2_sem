namespace Task_06_Tests;
using Task_06_ParseTree;

public class ParseTreeTests
{
    [Test]
    public void Test1() => Assert.That(new ParseTree("(* (+ 1 1) 2)").Calculate(), Is.EqualTo(4));

    [Test]
    public void Test2() => Assert.That(() => new ParseTree("(/ (+ 1 1) (- 1 1))").Calculate(), Throws.Exception.TypeOf<DivideByZeroException>());

    [Test]
    public void Test3() => Assert.That(new ParseTree("(* (+ 1 2) (/ 10 (- 9 7)))").Calculate(), Is.EqualTo(15));

    [Test]
    public void Test4() => Assert.That(() => new ParseTree("(* (+ 1 2) (/ 10 (- 9)))"), Throws.Exception.TypeOf<IncorrectExpressionException>());
    
    [Test]
    public void Test5() => Assert.That(() => new ParseTree(""), Throws.Exception.TypeOf<IncorrectExpressionException>());
    
    [Test]
    public void Test6() => Assert.That(() => new ParseTree("()"), Throws.Exception.TypeOf<IncorrectExpressionException>());

    [Test]
    public void Test7() => Assert.That(() => new ParseTree("(1)"), Throws.Exception.TypeOf<IncorrectExpressionException>());

    [Test]
    public void Test8() => Assert.That(new ParseTree("1").Calculate(), Is.EqualTo(1));

    [Test]
    public void Test9() => Assert.That(new ParseTree("(* (+ 1 2) (/ 10 (- 9 7)))").ToString(), Is.EqualTo("(* (+ 1 2) (/ 10 (- 9 7)))"));
}
