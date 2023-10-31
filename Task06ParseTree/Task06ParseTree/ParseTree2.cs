namespace Task06ParseTree;

public class ParseTree2
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
        OperandNode operand1;
        OperandNode operand2;
        Operation operation;

        public OperationNode(OperandNode operand1, OperandNode operand2, Operation operation)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.operation = operation;
        }

        public override double ToDouble()
            => operation.Count(operand1.ToDouble(), operand2.ToDouble());

        public override string ToString()
            => $"({operand1} {operand2} {operation})";
    }

    private class OperandNode : Node
    {
        OperandNode? operationNode;
        double value;

        public override double ToDouble()
        {
            if (operationNode == null)
                return value;
            return operationNode.ToDouble();
        }

        public override string ToString()
        {
            if (operationNode == null)
                return value.ToString();
            return operationNode.ToString();
        }
    }

    private OperandNode Parse()
    {
        throw new NotImplementedException();
    }
}
