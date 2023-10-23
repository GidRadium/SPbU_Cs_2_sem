namespace Task06ParseTree;

public class IncorrectExpressionException : Exception { }

public class ParseTree
{
    private class Operation
    {
        private char operationAsChar;
        public Operation(char operationAsChar) 
        {
            switch (operationAsChar)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    this.operationAsChar = operationAsChar;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public double Count(double operand1, double operand2)
        {
            switch (this.operationAsChar)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    if (operand2 > -0.0000001 && operand2 < 0.0000001)
                        throw new DivideByZeroException();
                    return operand1 / operand2;
                default:
                    throw new Exception("Invariant is violated.");
            }
        }

        public override string ToString()
        {
            return this.operationAsChar.ToString();
        }
    }

    private class Node
    {
        internal Operation? ExpressionOperation { get; set; }
        internal Node? Operand1 { get; set; }
        internal Node? Operand2 { get; set; }
        internal bool IsLeaf { get; set; }
        internal int Value { get; set; }

        public Node(string expression)
        {
            int value;
            if (int.TryParse(expression, out value))
            {
                this.Value = value;
                this.IsLeaf = true;
                this.Operand1 = null;
                this.Operand2 = null;
                this.ExpressionOperation = null;
                return;
            }

            if (expression.Length < "(+ 1 1)".Length || expression[0] != '(' || expression[2] != ' ' || expression[expression.Length - 1] != ')')
                throw new IncorrectExpressionException();

            try
            {
                this.ExpressionOperation = new Operation(expression[1]);
            }
            catch(ArgumentException)
            {
                throw new IncorrectExpressionException();
            }

            int count = 0;
            if (expression[3] == '(')
            {
                for (int i = 3; i < expression.Length - 1; i++)
                {
                    if (expression[i] == '(') count++;
                    if (expression[i] == ')') count--;
                    if (count == 0)
                    {
                        this.Operand1 = new Node(expression.Substring(3, i - 2));
                        this.Operand2 = new Node(expression.Substring(i + 2, expression.Length - i - 3));
                        return;
                    }
                }
            }
            else
            {
                for (int i = 3; i < expression.Length - 1; i++)
                {
                    if (expression[i] == ' ')
                    {
                        this.Operand1 = new Node(expression.Substring(3, i - 3));
                        this.Operand2 = new Node(expression.Substring(i + 1, expression.Length - i - 2));
                        return;
                    }
                }
            }
            
            throw new IncorrectExpressionException();
        }

        public override string ToString()
        {
            if (this.IsLeaf)
                return this.Value.ToString();
            return $"({this.ExpressionOperation} {this.Operand1} {this.Operand2})";
        }

        public double Calculate()
        {
            if (this.IsLeaf)
                return (double)this.Value;
            return this.ExpressionOperation.Count(this.Operand1.Calculate(), this.Operand2.Calculate());
        }
    }

    private Node root;

    public ParseTree(string expression)
    {
        this.root = new Node(expression);
    }

    public double Calculate()
    {
        return this.root.Calculate();
    }

    public override string ToString()
    {
        return this.root.ToString();
    }
}
