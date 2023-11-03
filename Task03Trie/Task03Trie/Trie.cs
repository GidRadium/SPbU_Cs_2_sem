using System.Xml.Linq;

namespace Task03Trie;

public class Trie
{
    private class Node
    {
        internal Dictionary<char, Node> Children { get; set; } = new Dictionary<char, Node>();
        internal int WordsPassedNumber { get; set; } = 0;
        internal bool IsEndOfWord { get; set; } = false;
    }

    private Node root = new Node();
    public int Size { get; private set; }
    private bool containsEmptyString;

    public bool Add(string element)
    {
        if (element == null)
            throw new ArgumentNullException(nameof(element));

        if (Contains(element))
            return false;

        if (element.Length == 0)
        {
            this.containsEmptyString = true;
            this.Size++;
            return true;
        }

        Node temp = this.root;
        for (int i = 0; i < element.Length; i++)
        {
            if (!temp.Children.ContainsKey(element[i]))
                temp.Children.Add(element[i], new Node());
            temp = temp.Children[element[i]];
            temp.WordsPassedNumber++;
        }

        temp.IsEndOfWord = true;
        this.Size++;

        return true;
    }

    public bool Contains(string element)
    {
        if (element == null)
            throw new ArgumentNullException(nameof(element));

        if (element.Length == 0)
            return this.containsEmptyString;

        Node temp = this.root;
        for (int i = 0; i < element.Length; i++)
        {
            if (!temp.Children.ContainsKey(element[i]))
                return false;
            temp = temp.Children[element[i]];
        }

        return temp.IsEndOfWord;
    }

    public bool Remove(string element)
    {
        if (element == null)
            throw new ArgumentNullException(nameof(element));

        if (!Contains(element))
            return false;

        if (element.Length == 0)
        {
            this.containsEmptyString = false;
            this.Size--;
            return true;
        }

        this.Size--;
        Node temp = this.root;
        for (int i = 0; i < element.Length; i++)
        {
            if (temp.Children[element[i]].WordsPassedNumber == 1)
            {
                temp.Children.Remove(element[i]);
                return true;
            }

            temp = temp.Children[element[i]];
            temp.WordsPassedNumber--;
        }

        temp.IsEndOfWord = false;

        return true;
    }

    public int HowManyStartsWithPrefix(string prefix)
    {
        if (prefix == null)
            throw new ArgumentNullException(nameof(prefix));

        if (prefix.Length == 0)
            return this.Size;

        Node temp = this.root;
        for (int i = 0; i < prefix.Length; i++)
        {
            if (!temp.Children.ContainsKey(prefix[i]))
                return 0;
            temp = temp.Children[prefix[i]];
        }

        return temp.WordsPassedNumber;
    }
}
