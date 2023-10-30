using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13SkipList;

public class SkipList<T> : IList<T> where T : IComparable<T>
{
    private int maxLevel = 16;
    private double probability = 0.5;
    private class Node<TValue>
    {
        public int Key { get; set; }
        public TValue Value { get; set; }
        public Node<TValue>[] Next { get; set; }
        
        public Node(int key, TValue value, int nodeLevel)
        {
            this.Key = key;
            this.Value = value;
            this.Next = new Node<TValue>[nodeLevel];
        }
    }

    private Node<T> root;
    private Node<T> nil;
    
    public SkipList()
    {
        this.root = new Node<T>(-1, default(T), this.maxLevel);
        this.nil = new Node<T>(int.MaxValue, default(T), this.maxLevel);

        for (int i = 0; i < this.maxLevel; i++)
            this.root.Next[i] = this.nil;
    }


    public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int IndexOf(T item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, T item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    
}
