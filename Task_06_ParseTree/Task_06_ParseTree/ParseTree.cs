using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_ParseTree;
internal class ParseTree
{
    private class Operation
    {
        private string OperationAsString;
        public Operation(string operationAsString) 
        {
            switch (operationAsString)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    this.OperationAsString = operationAsString;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public double Count(double operand1, double operand2)
        {
            switch (OperationAsString)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    if (operand2 > -0.0000001 && operand2 < 0.0000001)
                        throw new DivideByZeroException();
                    return operand1 / operand2;
                default:
                    throw new Exception("Invariant is violated.");
            }
        }

        public override string ToString()
        {
            return this.OperationAsString;
        }
    }

    private class Node
    {
        Operation? ExpressionOperation;
        Node? Operand1;
        Node? Operand2;
        bool IsLeaf = false;
        int Value;

        public Node(string expression)
        {
            if (int.TryParse(expression, out this.Value))
            {
                this.IsLeaf = true;
                this.Operand1 = null;
                this.Operand2 = null;
                this.ExpressionOperation = null;
                return;
            }

            //if () TODO
        }

        public override string ToString()
        {
            if (this.IsLeaf)
                return this.Value.ToString();
            return $"({this.ExpressionOperation.ToString()} {this.Operand1.ToString()} {this.Operand2.ToString()})";
        }

        public double Calculate()
        {
            if (IsLeaf)
                return (double)this.Value;
            return this.ExpressionOperation.Count(this.Operand1.Calculate(), this.Operand2.Calculate());
        }
    }

    private Node Root;

    public ParseTree(string expression)
    {
        this.Root = new Node(expression);
    }

    public double Calculate()
    {
        return this.Root.Calculate();
    }

    public override string ToString()
    {
        return this.Root.ToString();
    }
}
