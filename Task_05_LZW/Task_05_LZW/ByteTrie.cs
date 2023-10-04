using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_LZW
{
    internal class ByteTrie
    {
        private class Node
        {
            public Dictionary<byte, Node> Children;
            public int WordsPassedNumber;
            public bool IsEndOfWord;
            public uint WordCode;
            public Node()
            {
                this.Children = new Dictionary<byte, Node>();
                this.WordsPassedNumber = 0;
                this.IsEndOfWord = false;
            }
        }

        public uint LastCode { get; private set; }
        private Node Root;
        public int Size { get; private set; }

        public ByteTrie()
        {
            this.LastCode = 0;
            this.Root = new Node();
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


            Node temp = this.Root;
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

            Node temp = this.Root;
            for (int i = 0; i < element.Length; i++)
            {
                if (!temp.Children.ContainsKey(element[i]))
                    return 0;
                temp = temp.Children[element[i]];
            }

            return temp.WordCode;
        }
    }
}
