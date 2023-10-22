using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_StackCalculator
{
    public class StackCalculator
    {
        private IStack Stack;

        public StackCalculator(IStack stack)
        {
            this.Stack = stack;
        }
        
        public double Solve(string expression)
        {
            expression = expression.Trim();
            if (expression.Length == 0)
                return 0.0;
            var elements = expression.Split(' ');
            for (int i = 0; i < elements.Length; i++)
            {
                switch (elements[i])
                {
                    case "+":
                        this.Stack.Push(Stack.Pop() + this.Stack.Pop());
                        break;
                    case "-":
                        this.Stack.Push(-this.Stack.Pop() + this.Stack.Pop());
                        break;
                    case "*":
                        this.Stack.Push(this.Stack.Pop() * this.Stack.Pop());
                        break;
                    case "/":
                        double b = this.Stack.Pop();
                        double a = this.Stack.Pop();
                        if (b > -0.000001 && b < 0.000001)
                        {
                            while (this.Stack.Size > 0)
                                Stack.Pop();
                            throw new Exception("Can't devide by 0");
                        }
                            
                        this.Stack.Push(a / b);
                        break;
                    default:
                        double value;
                        if (!Double.TryParse(elements[i], out value))
                        {
                            while (this.Stack.Size > 0)
                                Stack.Pop();
                            throw new Exception($"{elements[i]} is not double.");
                        }
                            
                        this.Stack.Push(value);
                        break;
                }
            }

            if (this.Stack.Size != 1)
            {
                while (this.Stack.Size > 0)
                    Stack.Pop();
                throw new Exception($"Expression is incorrect");
            }

            return this.Stack.Pop();
        }
    }
}
