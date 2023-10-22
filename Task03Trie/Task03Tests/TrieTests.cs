using Task03Trie;
namespace Task03Tests;

[TestFixture]
public class TrieTests
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
        trie.Add(""); //
    }

    [Test]
    public void TrieContainsReturnsTrueCorrectly1()
        => Assert.IsTrue(trie.Contains("lolo"));


    [Test]
    public void TrieContainsReturnsFalseCorrectly1()
        => Assert.IsFalse(trie.Contains("lol"));

    [Test]
    public void TrieContainsReturnsTrueCorrectly2()
        => Assert.IsTrue(trie.Contains("Trie"));

    [Test]
    public void TrieContainsReturnsFalseCorrectly2()
        => Assert.IsFalse(trie.Contains("Trie is"));

    [Test]
    public void TrieHowManyStartsWithPrefixReturnsCorrectNumber1()
        => Assert.That(trie.HowManyStartsWithPrefix("Trie"), Is.EqualTo(3));

    [Test]
    public void TrieHowManyStartsWithPrefixReturnsCorrectNumber2()
        => Assert.That(trie.HowManyStartsWithPrefix("Trie "), Is.EqualTo(2));

    [Test]
    public void TrieSizeReturnsCorrectValue()
        => Assert.That(trie.Size, Is.EqualTo(6));
}
