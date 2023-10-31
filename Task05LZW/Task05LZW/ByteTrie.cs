namespace Task05LZW;

internal class ByteTrie
{
    private class Node
    {
        internal Dictionary<byte, Node> Children { get; set; } = new Dictionary<byte, Node>();
        internal int WordsPassedNumber { get; set; } = 0;
        internal bool IsEndOfWord { get; set; } = false;
        internal uint WordCode { get; set; } = 0;
    }

    public uint LastCode { get; private set; } = 0;
    private Node root = new Node();
    public int Size { get; private set; } = 0;

    public uint Add(byte[] element)
    {
        if (element == null)
            throw new ArgumentNullException(nameof(element));

        if (element.Length == 0)
            return 0;

        if (Contains(element) != 0)
            return Contains(element);

        Node temp = this.root;
        for (int i = 0; i < element.Length; i++)
        {
            if (!temp.Children.ContainsKey(element[i]))
                temp.Children.Add(element[i], new Node());
            temp = temp.Children[element[i]];
            temp.WordsPassedNumber++;
        }

        temp.IsEndOfWord = true;
        temp.WordCode = ++this.LastCode;
        this.Size++;

        return temp.WordCode;
    }

    public uint Contains(byte[] element)
    {
        if (element == null)
            throw new ArgumentNullException(nameof(element));

        if (element.Length == 0)
            return 0;

        Node temp = this.root;
        for (int i = 0; i < element.Length; i++)
        {
            if (!temp.Children.ContainsKey(element[i]))
                return 0;
            temp = temp.Children[element[i]];
        }

        return temp.WordCode;
    }
}
