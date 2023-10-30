using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task13SkipList;

public class SkipList<T> : IList<T>
{
    private int maxLevel = 16;
    private double probability = 0.5;
    private int version = 0;

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

    public T this[int index] {
        get
        {
            if ((uint)index >= (uint)this.Count)
                throw new IndexOutOfRangeException();

            int level = this.maxLevel - 1;
            Node<T> temp = this.root;
            while (level >= 0)
            {
                if (index > temp.Key)
                    temp = temp.Next[level];
                else
                    level--;
            }

            if (temp.Key == index)
                return temp.Value;

            throw new IndexOutOfRangeException();
        }

        set
        {
            if ((uint)index >= (uint)this.Count)
                throw new IndexOutOfRangeException();

            this.Insert(index, value);
        }
    }

    public int Count { get; private set; }

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        this.version++;
        int index = int.MaxValue - 1;
        var update = new Node<T>[this.maxLevel];
        int level = this.maxLevel - 1;
        Node<T> temp = this.root;
        while (level >= 0)
        {
            if (index > temp.Key)
            {
                temp = temp.Next[level];
            }
            else
            {
                update[level] = temp;
                level--;
            }
        }

        int nodeLevel = 1;
        var rnd = new Random();
        for (int i = 0; i < this.maxLevel; i++)
        {
            if (rnd.NextDouble() > this.probability) break;
            nodeLevel++;
        }

        this.Count++;
        var node = new Node<T>(update[0].Key + 1, item, nodeLevel);
        for (int i = 0; i < nodeLevel; i++)
        {
            node.Next[i] = update[i].Next[i];
            update[i].Next[i] = node;
        }
    }

    public void Clear()
    {
        this.version++;
        for (int i = 0; i < this.maxLevel; i++)
            this.root.Next[i] = this.nil;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) >= 0;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        if (array == null)
            throw new ArgumentNullException();

        if (array.Rank != 1)
            throw new ArgumentException();

        if (arrayIndex < 0)
            throw new ArgumentOutOfRangeException();

        List<T> list = new List<T>();

        for (var temp = this.root.Next[0]; temp != this.nil; temp = temp.Next[0])
            if (temp.Key >= arrayIndex)
                list.Add(temp.Value);

        Array.Copy(list.ToArray(), 0, array, arrayIndex, list.Count);
    }

    public int IndexOf(T item)
    {
        for (var temp = this.root.Next[0]; temp != this.nil; temp = temp.Next[0])
        {
            if (item.Equals(temp.Value))
                return temp.Key;
        }

        return -1;
    }

    public void Insert(int index, T item)
    {
        this.version++;

        var update = new Node<T>[this.maxLevel];
        int level = this.maxLevel - 1;
        Node<T> temp = this.root;
        while (level >= 0)
        {
            if (index > temp.Key)
            {
                temp = temp.Next[level];
            }
            else
            {
                update[level] = temp;
                level--;
            }
        }

        if (temp.Key == index)
        {
            temp.Value = item;
            return;
        }

        int nodeLevel = 1;
        var rnd = new Random();
        for (int i = 0; i < this.maxLevel; i++)
        {
            if (rnd.NextDouble() > this.probability) break;
            nodeLevel++;
        }

        this.Count++;
        var node = new Node<T>(index, item, nodeLevel);
        for (int i = 0; i < nodeLevel; i++)
        {
            node.Next[i] = update[i].Next[i];
            update[i].Next[i] = node;
        }
    }

    public bool Remove(T item)
    {
        var temp = this.root;
        bool result = false;
        while (temp != this.nil)
        {
            if (temp.Value.Equals(item))
            {
                int index = temp.Key;
                temp = temp.Next[0];

                this.RemoveAt(index);
                result = true;
            }
        }

        if (result)
            this.version++;

        return result;
    }

    public void RemoveAt(int index)
    {
        var update = new Node<T>[this.maxLevel];
        int level = this.maxLevel - 1;
        Node<T> temp = this.root;
        while (level >= 0)
        {
            if (index > temp.Key)
            {
                temp = temp.Next[level];
            }
            else
            {
                update[level] = temp;
                level--;
            }
        }

        if (temp.Key != index)
            return;

        this.version++;

        this.Count--;
        for (int i = 0; i < temp.Next.Length; i++)
            update[i].Next[i] = temp.Next[i];
    }

    public struct Enumerator : IEnumerator<T>, IEnumerator
    {
        private readonly SkipList<T> list;
        private Node<T> node;
        private readonly int version;
        private T? current;

        internal Enumerator(SkipList<T> list)
        {
            this.list = list;
            this.node = list.root.Next[0];
            this.version = list.version;
            this.current = default;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (this.version == this.list.version && this.node != this.list.nil)
            {
                this.current = node.Value;
                this.node = node.Next[0];
                return true;
            }

            return MoveNextRare();
        }

        private bool MoveNextRare()
        {
            if (this.version != this.list.version)
                throw new InvalidOperationException();

            this.node = null;
            this.current = default;
            return false;
        }

        public T Current => this.current!;

        object? IEnumerator.Current
        {
            get
            {
                if (this.node == this.list.root.Next[0] || this.node == null)
                    throw new InvalidOperationException();
                return this.Current;
            }
        }

        void IEnumerator.Reset()
        {
            if (this.version != this.list.version)
                throw new InvalidOperationException();

            this.node = this.list.root.Next[0];
            this.current = default;
        }
    }

    public Enumerator GetEnumerator()
        => new Enumerator(this);

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
        => new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator()
        => new Enumerator(this);
}
