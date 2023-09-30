using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_StackCalculator
{
    class ListStack : IStack
    {
        private List<double> Data;

        public ListStack()
        {
            this.Data = new List<double>();
            this.Size = 0;
        }

        public int Size { get; private set; }

        public void Push(double value)
        {
            this.Data.Add(value);
            this.Size++;
        }

        public double Pop()
        {
            if (this.Size == 0)
                throw new Exception("ListStack.Pop(): Stack is empty!");
            double result = this.Data[this.Size - 1];
            this.Data.RemoveAt(this.Size - 1);
            return result;
        }

        public double Top()
        {
            if (this.Size == 0)
                throw new Exception("ListStack.Top(): Stack is empty!");
            return this.Data[this.Size - 1];
        }
    }
}
