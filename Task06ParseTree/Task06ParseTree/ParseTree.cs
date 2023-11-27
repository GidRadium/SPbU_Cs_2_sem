namespace Task06ParseTree;

/// <summary>
/// Main project class. Parses expressions like (<operation> <operand1> <operand2>), where operand can also be an expression.
/// </summary>
public class ParseTree
{
    /// <summary>
    /// Base class of Operations used in expressions.
    /// </summary>
    private abstract class Operation
    {
        public abstract double Count(double operand1, double operand2);
        public abstract override string ToString();
    }

    /// <summary>
    /// Represents "+" in expression.
    /// </summary>
    private class Addition : Operation
    {
        public override double Count(double operand1, double operand2) => operand1 + operand2;

        public override string ToString() => "+";
    }

    /// <summary>
    /// Represents "-" in expression.
    /// </summary>
    private class Subtraction : Operation
    {
        public override double Count(double operand1, double operand2) => operand1 - operand2;

        public override string ToString() => "-";
    }

    /// <summary>
    /// Represents "*" in expression.
    /// </summary>
    private class Multiplication : Operation
    {
        public override double Count(double operand1, double operand2) => operand1 * operand2;

        public override string ToString() => "*";
    }

    /// <summary>
    /// Represents "/" in expression.
    /// </summary>
    private class Division : Operation
    {
        public override double Count(double operand1, double operand2)
        {
            if (Math.Abs(operand2) < 0.0000001)
                throw new DivideByZeroException();
            return operand1 / operand2;
        }

        public override string ToString() => "/";
    }

    /// <summary>
    /// Base class of Nodes. Represents value from expression.
    /// </summary>
    private class Node
    {
        private double value;

        public virtual double GetValue() => value;
        public double SetValue(double value) => this.value = value;

        public override string ToString() => value.ToString();
    }

    /// <summary>
    /// Class of Node, that represents operation.
    /// </summary>
    private class OperationNode : Node
    {
        public override double GetValue()
            => ExpressionOperation.Count(Operand1.GetValue(), Operand2.GetValue());

        public Node Operand1;
        public Node Operand2;
        public Operation ExpressionOperation;

        public OperationNode(Node operand1, Node operand2, Operation operation)
        {
            this.Operand1 = operand1;
            this.Operand2 = operand2;
            this.ExpressionOperation = operation;
        }

        public override string ToString()
            => $"({ExpressionOperation} {Operand1} {Operand2})";
    }

    private Node root;

    private Node Parse(string expression)
    {
        if (expression == null)
            throw new NullReferenceException(nameof(expression));

        
        Node node;

        if (int.TryParse(expression, out int value))
        {
            node = new Node();
            node.SetValue(value);
            return node;
        }

        if (expression.Length < "(+ 1 1)".Length || expression[0] != '(' || expression[2] != ' ' || expression[expression.Length - 1] != ')')
            throw new IncorrectExpressionException();
        
        Operation operation = expression[1] switch
        {
            '+' => new Addition(),
            '-' => new Subtraction(),
            '*' => new Multiplication(),
            '/' => new Division(),
            _ => throw new IncorrectExpressionException(),
        };

        int count = 0;
        if (expression[3] == '(')
        {
            for (int i = 3; i < expression.Length - 1; i++)
            {
                if (expression[i] == '(') count++;
                if (expression[i] == ')') count--;
                if (count == 0)
                {
                    node = new OperationNode
                    (
                        this.Parse(expression.Substring(3, i - 2)),
                        this.Parse(expression.Substring(i + 2, expression.Length - i - 3)),
                        operation
                    );
                    return node;
                }
            }
        }
        else
        {
            for (int i = 3; i < expression.Length - 1; i++)
            {
                if (expression[i] == ' ')
                {
                    node = new OperationNode
                    (
                        this.Parse(expression.Substring(3, i - 3)),
                        this.Parse(expression.Substring(i + 1, expression.Length - i - 2)),
                        operation
                    );
                    return node;
                }
            }
        }

        throw new IncorrectExpressionException();
    }

    /// <summary>
    /// Constructor, that parses tree by expression.
    /// </summary>
    public ParseTree(string expression)
    {
        if (expression == null)
            throw new NullReferenceException(nameof(expression));

        this.root = Parse(expression);
    }

    /// <summary>
    /// Passes throught all nodes.
    /// </summary>
    /// <returns>Result of the expression.</returns>
    public double Count()
        => this.root.GetValue();

    /// <summary>
    /// Passes throught all nodes.
    /// </summary>
    /// <returns>Expression as string.</returns>
    public override string ToString()
        => this.root.ToString();
}
