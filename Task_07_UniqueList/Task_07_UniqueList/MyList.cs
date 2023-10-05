﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_UniqueList;
internal class MyList
{
    public int Size { get; private set; }

    protected class Node
    {
        public int Value;
        public Node? Next;
    }

    private Node? Root = null;

    public virtual void AddValue(int value, int index)
    {
        if (index < 0 || index > this.Size)
            throw new ArgumentOutOfRangeException();

        var node = new Node();
        node.Value = value;
        
        if (this.Size == 0)
        {
            this.Root = node;
            this.Size++;
            return;
        }
        
        if (index == 0)
        {
            node.Next = this.Root;
            this.Root = node;
            this.Size++;
            return;
        }

        var temp = this.Root;
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

        var temp = this.Root;
        for (int i = 0; i < this.Size; i++)
            temp = temp.Next;

        return temp.Value;
    }

    public virtual void SetValue(int value, int index)
    {
        if (index < 0 || index > this.Size - 1)
            throw new ArgumentOutOfRangeException();

        var temp = this.Root;
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
            this.Root = this.Root.Next;
            this.Size--;
            return;
        }

        var temp = this.Root;
        for (int i = 0; i < index; i++)
            temp = temp.Next;

        temp.Next = temp.Next.Next;
        this.Size--;
    }

    public bool Contains(int value)
    {
        var temp = this.Root;
        for (int i = 0; i < this.Size; i++)
            if (temp.Value == value) 
                return true;

        return false;
    }
}
