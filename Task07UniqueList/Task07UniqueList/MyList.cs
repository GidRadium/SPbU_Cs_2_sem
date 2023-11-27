namespace Task07UniqueList;

/// <summary>
/// List class.
/// </summary>
public class MyList
{
    public int Size { get; private set; }

    private class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
    }

    private Node? root;

    private Node GetNodeBeforeIndex(int index)
    {
        var temp = this.root;
        for (int i = 0; i < index; i++)
            temp = temp.Next;
        return temp;
    }

    /// <summary>
    /// Inserts value to the list to the index position.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
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

        var temp = GetNodeBeforeIndex(index - 1);

        node.Next = temp.Next;
        temp.Next = node;
        Size++;
    }

    /// <returns>Value on index position in the list.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public int GetValue(int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException(nameof(index));

        var temp = GetNodeBeforeIndex(index);

        return temp.Value;
    }

    /// <summary>
    /// Sets the value to the index position.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public virtual void SetValue(int value, int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException(nameof(index));

        var temp = GetNodeBeforeIndex(index);

        temp.Value = value;
    }

    /// <summary>
    /// Deletes list value on the index position.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
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

        var temp = GetNodeBeforeIndex(index);

        temp.Next = temp.Next.Next;
        this.Size--;
    }

    /// <summary>
    /// Checks if the value is in the list.
    /// </summary>
    /// <returns>True if list contains the value.</returns>
    public bool Contains(int value)
        => FindIndexByValue(value) >= 0;

    /// <summary>
    /// Looks up the index of the value in the list.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>First occurrence index from 0 to Size if list contains the value. Otherwise -1.</returns>
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
