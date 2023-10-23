namespace Task05LZW;

internal class ByteTrie
{
    private class Node
    {
        internal Dictionary<byte, Node> Children { get; set; }
        internal int WordsPassedNumber { get; set; }
        internal bool IsEndOfWord { get; set; }
        internal uint WordCode { get; set; }
        public Node()
        {
            this.Children = new Dictionary<byte, Node>();
            this.WordsPassedNumber = 0;
            this.IsEndOfWord = false;
        }
    }

    public uint LastCode { get; private set; }
    private Node root;
    public int Size { get; private set; }

    public ByteTrie()
    {
        this.LastCode = 0;
        this.root = new Node();
        this.Size = 0;
    }

    public uint Add(byte[] element)
    {
        if (element == null || element.Length == 0)
            return 0;

        if (Contains(element) != 0)
        {
            return Contains(element);
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
        temp.WordCode = ++this.LastCode;
        this.Size++;

        return temp.WordCode;
    }

    public uint Contains(byte[] element)
    {
        if (element == null)
            return 0;
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
