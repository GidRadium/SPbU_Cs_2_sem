namespace Task07UniqueList;

// List class.
public class MyList
{
    public int Size { get; private set; }

    private class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
    }

    private Node? root;

    private Node getNodeBeforeIndex(int index)
    {
        var temp = this.root;
        for (int i = 0; i < index; i++)
            temp = temp.Next;
        return temp;
    }

    public virtual void AddValue(int value, int index)
    {
        if (index < 0 || index > this.Size)
            throw new ArgumentOutOfRangeException(nameof(index));

        var node = new Node();
        node.Value = value;
        
        if (this.Size == 0)
        {
            this.root = node;
            this.Size++;
            return;
        }
        
        if (index == 0)
        {
            node.Next = this.root;
            this.root = node;
            this.Size++;
            return;
        }

        var temp = getNodeBeforeIndex(index - 1);

        node.Next = temp.Next;
        temp.Next = node;
        Size++;
    }

    public int GetValue(int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException(nameof(index));

        var temp = getNodeBeforeIndex(index);

        return temp.Value;
    }

    public virtual void SetValue(int value, int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException(nameof(index));

        var temp = getNodeBeforeIndex(index);

        temp.Value = value;
    }

    public virtual void DeleteValue(int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == 0)
        {
            this.root = this.root.Next;
            this.Size--;
            return;
        }

        var temp = getNodeBeforeIndex(index);

        temp.Next = temp.Next.Next;
        this.Size--;
    }

    public bool Contains(int value)
        => FindIndexByValue(value) >= 0;

    public int FindIndexByValue(int value)
    {
        var temp = this.root;
        for (int i = 0; i < this.Size; i++)
        {
            if (temp.Value == value)
                return i;
            temp = temp.Next;
        }

        return -1;
    }
}
