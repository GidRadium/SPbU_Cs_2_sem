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
        private bool ContainsEmptyString;

        public Trie()
        {
            this.Root = new Node();
            this.Size = 0;
            this.ContainsEmptyString = false;
        }

        private void AddToNode(Node node, string elementSuffix)
        {
            char symbol = elementSuffix[0];

            if (!node.Children.ContainsKey(symbol))
                node.Children.Add(symbol, new Node());

            node.Children[symbol].WordsPassedNumber++;

            if (elementSuffix.Length == 1)
            {
                node.Children[symbol].IsEndOfWord = true;
                this.Size++;
                return;
            }

            AddToNode(node.Children[symbol], elementSuffix.Substring(1));
        }

        bool Add(string element)
        {
            if (element == null || Contains(element))
                return false;

            if (element.Length == 0) 
                return this.ContainsEmptyString = true;

            AddToNode(this.Root, element);
            return true;
        }

        bool Contains(string element)
        {
            if (element == null) 
                return false;
            if (element.Length == 0)
                return this.ContainsEmptyString;

            Node temp = Root;
            for (int i = 0; i < element.Length; i++)
            {
                if (!temp.Children.ContainsKey(element[i]))
                    return false;
                temp = temp.Children[element[i]];
            }

            return temp.IsEndOfWord;
        }

        bool Remove(string element)
        {

        }

        int HowManyStartsWithPrefix(string prefix)
        {

        }
    }
}
