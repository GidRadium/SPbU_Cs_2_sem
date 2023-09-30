using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_StackCalculator
{
    interface IStack
    {
        public int Size { get; }

        void Push(double value);

        double Pop();

        double Top();
    }
}
