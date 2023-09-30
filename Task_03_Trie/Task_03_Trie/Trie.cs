using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Trie
{
    internal class Trie
    {
        private class Node
        {
            public Dictionary<char, Node> Children;
            public int WordsPassedNumber;
            public bool IsEndOfWord;

            public Node()
            {
                this.Children = new Dictionary<char, Node>();
                this.WordsPassedNumber = 0;
                this.IsEndOfWord = false;
            }
        }

        private Node Root;

        public int Size { get; private set; }

        public Trie()
        {
            this.Root = new Node();
        }

        private bool AddToNode(Node node, string elementSuffix)
        {

        }

        bool Add(string element)
        {

        }

        bool Contains(string element) { }

        bool Remove(string element) { }

        int HowManyStartsWithPrefix(string prefix) { }
    }
}
