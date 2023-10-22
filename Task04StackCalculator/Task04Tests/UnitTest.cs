using Task_04_StackCalculator;

public abstract class TestBase
{
    public StackCalculator stackCalculator;

    [Test]
    public void Test1() => Assert.That(this.stackCalculator.Solve("1 1 +") == 2, Is.True);

    [Test]
    public void Test2() => Assert.That(this.stackCalculator.Solve("9 4 2 * +") == 17, Is.True);

    [Test]
    public void Test3() => Assert.That(this.stackCalculator.Solve("0 0 0 0 + * -") == 0, Is.True);

    [Test]
    public void Test4() => Assert.That(this.stackCalculator.Solve("5 2 /") > 2.5 - 0.000001
                                    && this.stackCalculator.Solve("5 2 /") < 2.5 + 0.000001, Is.True);

    [Test]
    public void Test5() => Assert.That(() => this.stackCalculator.Solve("1 0 /"), Throws.Exception);

    [Test]
    public void Test6() => Assert.That(() => this.stackCalculator.Solve("1 1 1 - /"), Throws.Exception);

    [Test]
    public void Test7() => Assert.That(() => this.stackCalculator.Solve("1 1 1 -"), Throws.Exception);

    [Test]
    public void Test8() => Assert.That(() => this.stackCalculator.Solve("1 1 - *"), Throws.Exception);

    [Test]
    public void Test9() => Assert.That(() => this.stackCalculator.Solve("1 a -"), Throws.Exception);
}


[TestFixture]
public class TestArrayStackCalculator : TestBase
{
    [SetUp]
    public void Setup() => this.stackCalculator = new StackCalculator(new ArrayStack());
}

[TestFixture]
public class TestListStackCalculator : TestBase
{
    [SetUp]
    public void Setup() => this.stackCalculator = new StackCalculator(new ListStack());
}
