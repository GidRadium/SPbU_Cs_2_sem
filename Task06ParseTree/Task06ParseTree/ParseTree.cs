namespace Task06ParseTree;

public class ParseTree
{
    private abstract class Operation
    {
        public abstract double Count(double operand1, double operand2);
        public abstract override string ToString();
    }

    private class Addition : Operation
    {
        public override double Count(double operand1, double operand2) => operand1 + operand2;

        public override string ToString() => "+";
    }

    private class Subtraction : Operation
    {
        public override double Count(double operand1, double operand2) => operand1 - operand2;

        public override string ToString() => "-";
    }

    private class Multiplication : Operation
    {
        public override double Count(double operand1, double operand2) => operand1 * operand2;

        public override string ToString() => "*";
    }

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

    private abstract class Node
    {
        public abstract override string ToString();

        public abstract double ToDouble();
    }

    private class OperationNode : Node
    {
        public OperandNode Operand1;
        public OperandNode Operand2;
        public Operation ExpressionOperation;

        public OperationNode(OperandNode operand1, OperandNode operand2, Operation operation)
        {
            this.Operand1 = operand1;
            this.Operand2 = operand2;
            this.ExpressionOperation = operation;
        }

        public override double ToDouble()
            => ExpressionOperation.Count(Operand1.ToDouble(), Operand2.ToDouble());

        public override string ToString()
            => $"({ExpressionOperation} {Operand1} {Operand2})";
    }

    private class OperandNode : Node
    {
        public OperationNode? ExpressionOperationNode;
        public double Value;

        public override double ToDouble()
        {
            if (ExpressionOperationNode == null)
                return Value;
            return ExpressionOperationNode.ToDouble();
        }

        public override string ToString()
        {
            if (ExpressionOperationNode == null)
                return Value.ToString();
            return ExpressionOperationNode.ToString();
        }
    }

    OperandNode root;

    private OperandNode Parse(string expression)
    {
        if (expression == null)
            throw new NullReferenceException(nameof(expression));

        OperandNode node = new();
        
        if (int.TryParse(expression, out int value))
        {
            node.Value = value;
            return node;
        }

        if (expression.Length < "(+ 1 1)".Length || expression[0] != '(' || expression[2] != ' ' || expression[expression.Length - 1] != ')')
            throw new IncorrectExpressionException();

        Operation operation;
        switch (expression[1])
        {
            case '+':
                operation = new Addition();
                break;
            case '-':
                operation = new Subtraction();
                break;
            case '*':
                operation = new Multiplication();
                break;
            case '/':
                operation = new Division();
                break;
            default:
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
                    node.ExpressionOperationNode = new OperationNode
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
                    node.ExpressionOperationNode = new OperationNode
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

    public ParseTree(string expression)
    {
        if (expression == null)
            throw new NullReferenceException(nameof(expression));

        this.root = Parse(expression);
    }

    public double Count()
        => this.root.ToDouble();

    public override string ToString()
        => this.root.ToString();
}
