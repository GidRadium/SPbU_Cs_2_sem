using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_StackCalculator
{
    public class ArrayStack : IStack
    {
        private double[] Data;

        public ArrayStack()
        {
            this.Data = new double[2];
            this.Size = 0;
        }

        public int Size { get; private set; }

        public void Push(double value)
        {
            if (this.Data.Length == this.Size)
                Array.Resize(ref this.Data, this.Size * 2);

            this.Data[this.Size] = value;
            this.Size++;
        }

        public double Pop()
        {
            if (this.Size == 0)
                throw new Exception("ArrayStack.Pop(): Stack is empty!");

            this.Size--;
            return this.Data[this.Size];
        }

        public double Top()
        {
            if (this.Size == 0)
                throw new Exception("ArrayStack.Top(): Stack is empty!");

            return this.Data[this.Size - 1];
        }
    }
}
