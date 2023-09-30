using Task_03_Trie;

namespace Task_03_Tests
{
    [TestFixture]
    public class Tests
    {
        private Trie trie;

        [SetUp]
        public void Setup()
        {
            trie = new Trie();
            trie.Add("lolol");
            trie.Add("lolo"); //
            trie.Add("lol");
            trie.Add("l");
            trie.Remove("lol");
            trie.Remove("l");
            trie.Remove("lolol");
            trie.Add("kek"); //
            trie.Add("Trie"); //
            trie.Add("Trie is good"); //
            trie.Add("Trie is");
            trie.Add("Trie is the best"); //
            trie.Remove("Trie is");
            trie.Remove("?");
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(trie.Contains("lolo"));
        }

        [Test]
        public void Test2()
        {
            Assert.IsFalse(trie.Contains("lol"));
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(trie.Contains("Trie"));
        }

        [Test]
        public void Test4()
        {
            Assert.IsFalse(trie.Contains("Trie is"));
        }

        [Test]
        public void Test5()
        {
            Assert.That(trie.HowManyStartsWithPrefix("Trie"), Is.EqualTo(3));
        }

        [Test]
        public void Test6()
        {
            Assert.That(trie.HowManyStartsWithPrefix("Trie "), Is.EqualTo(2));
        }
    }
}
