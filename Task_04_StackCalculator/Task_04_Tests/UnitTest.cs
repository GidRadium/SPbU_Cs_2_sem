using Task_04_StackCalculator;

namespace Task_04_Tests
{
    [TestFixture]
    public class Tests
    {
        private StackCalculator arrayStackCalculator;
        private StackCalculator listStackCalculator;

        [SetUp]
        public void Setup()
        {
            this.arrayStackCalculator = new StackCalculator(new ArrayStack());
            this.listStackCalculator = new StackCalculator(new ListStack());
        }

        [Test]
        public void TestCorrectArrayStackCalculator()
        {
            Assert.Multiple(() =>
            {
                Assert.That(this.arrayStackCalculator.Solve("1 1 +") == 2, Is.True);
                Assert.That(this.arrayStackCalculator.Solve("9 4 2 * +") == 17, Is.True);
                Assert.That(this.arrayStackCalculator.Solve("0 0 0 0 + * -") == 0, Is.True);
                Assert.That(this.arrayStackCalculator.Solve("5 2 /") > 2.5 - 0.000001
                    && this.arrayStackCalculator.Solve("5 2 /") < 2.5 + 0.000001, Is.True);
            });
        }

        [Test]
        public void TestCorrectListStackCalculator()
        {
            Assert.Multiple(() =>
            {
                Assert.That(this.listStackCalculator.Solve("1 1 +") == 2, Is.True);
                Assert.That(this.listStackCalculator.Solve("9 4 2 * +") == 17, Is.True);
                Assert.That(this.listStackCalculator.Solve("0 0 0 0 + * -") == 0, Is.True);
                Assert.That(this.listStackCalculator.Solve("5 2 /") > 2.5 - 0.000001
                    && this.listStackCalculator.Solve("5 2 /") < 2.5 + 0.000001, Is.True);
            });
        }

        [Test]
        public void TestIncorrectArrayStackCalculator()
        {
            Assert.Multiple(() =>
            {
                Assert.That(() => this.arrayStackCalculator.Solve("1 0 /"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 1 1 - /"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 1 1 -"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 1 - *"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 a -"), Throws.Exception);
            });
        }

        [Test]
        public void TestIncorrectListStackCalculator()
        {
            Assert.Multiple(() =>
            {
                Assert.That(() => this.arrayStackCalculator.Solve("1 0 /"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 1 1 - /"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 1 1 -"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 1 - *"), Throws.Exception);
                Assert.That(() => this.arrayStackCalculator.Solve("1 a -"), Throws.Exception);
            });
        }
    }
}
