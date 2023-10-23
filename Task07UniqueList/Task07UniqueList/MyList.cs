namespace Task07UniqueList;
public class MyList
{
    public int Size { get; private set; }

    protected class Node
    {
        internal int Value { get; set; }
        internal Node? Next { get; set; }
    }

    private Node? root = null;

    public virtual void AddValue(int value, int index)
    {
        if (index < 0 || index > this.Size)
            throw new ArgumentOutOfRangeException();

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

        var temp = this.root;
        for (int i = 0; i < index - 1; i++)
            temp = temp.Next;

        node.Next = temp.Next;
        temp.Next = node;
        Size++;
    }

    public int GetValue(int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException();

        var temp = this.root;
        for (int i = 0; i < index; i++)
            temp = temp.Next;

        return temp.Value;
    }

    public virtual void SetValue(int value, int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException();

        var temp = this.root;
        for (int i = 0; i < index; i++)
            temp = temp.Next;

        temp.Value = value;
    }

    public virtual void DeleteValue(int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException();

        if (index == 0)
        {
            this.root = this.root.Next;
            this.Size--;
            return;
        }

        var temp = this.root;
        for (int i = 0; i < index; i++)
            temp = temp.Next;

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
