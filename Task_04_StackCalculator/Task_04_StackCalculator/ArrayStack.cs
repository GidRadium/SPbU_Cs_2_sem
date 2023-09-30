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
            Data = new double[2];
            Size = 0;
        }

        public int Size { get; private set; }

        public void Push(double value)
        {
            if (Data.Length == Size)
                Array.Resize(ref Data, Size * 2);
            Data[Size] = value;
            Size++;
        }

        public double Pop()
        {
            if (Size == 0)
                throw new Exception("ArrayStack.Pop(): Stack is empty!");
            Size--;
            return Data[Size];
        }

        public double Top()
        {
            if (Size == 0)
                throw new Exception("ArrayStack.Pop(): Stack is empty!");
            return Data[Size - 1];
        }
    }
}
