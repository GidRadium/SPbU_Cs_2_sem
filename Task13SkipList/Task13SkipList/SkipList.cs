using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13SkipList;

public class SkipList<T> : IList<T>
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

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        for (int i = 0; i < this.maxLevel; i++)
            this.root.Next[i] = this.nil;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) >= 0;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(T item)
    {
        for (var temp = this.root; temp != this.nil; temp = temp.Next[0])
        {
            if (item.Equals(temp.Value))
                return temp.Key;
        }

        return -1;
    }

    public void Insert(int index, T item)
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
        throw new NotImplementedException();
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

        this.Count--;
        for (int i = 0; i < temp.Next.Length; i++)
            update[i].Next[i] = temp.Next[i];
    }

    public struct Enumerator : IEnumerator<T>, IEnumerator
    {
        private readonly SkipList<T> _list;
        private int _index;
        private readonly int _version;
        private T? _current;

        internal Enumerator(SkipList<T> list)
        {
            _list = list;
            _index = 0;
            _version = list._version;
            _current = default;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            List<T> localList = _list;

            if (_version == localList._version && ((uint)_index < (uint)localList._size))
            {
                _current = localList._items[_index];
                _index++;
                return true;
            }
            return MoveNextRare();
        }

        private bool MoveNextRare()
        {
            if (_version != _list._version)
            {
                ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
            }

            _index = _list._size + 1;
            _current = default;
            return false;
        }

        public T Current => _current!;

        object? IEnumerator.Current
        {
            get
            {
                if (_index == 0 || _index == _list._size + 1)
                {
                    ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
                }
                return Current;
            }
        }

        void IEnumerator.Reset()
        {
            if (_version != _list._version)
            {
                ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
            }

            _index = 0;
            _current = default;
        }
    }


    public Enumerator GetEnumerator()
        => new Enumerator(this);

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
        => new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator()
        => new Enumerator(this);
}
