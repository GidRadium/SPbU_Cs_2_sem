namespace Task04StackCalculator;

public class StackCalculator
{
    public const double Delta = 0.000001;
    private IStack stack;

    public StackCalculator(IStack stack)
    {
        this.stack = stack;
    }
    
    public double Solve(string expression)
    {
        expression = expression.Trim();
        if (expression.Length == 0)
            return 0.0;
        var elements = expression.Split(' ');
        for (int i = 0; i < elements.Length; i++)
        {
            if (this.stack.Size < 2
                && (elements[i] == "+"
                || elements[i] == "-"
                || elements[i] == "*"
                || elements[i] == "/"))
            {
                this.stack.Clear();
                throw new ArgumentException("Expression is incorrect");
            }

            switch (elements[i])
            {
                case "+":
                    this.stack.Push(stack.Pop() + this.stack.Pop());
                    break;
                case "-":
                    this.stack.Push(-this.stack.Pop() + this.stack.Pop());
                    break;
                case "*":
                    this.stack.Push(this.stack.Pop() * this.stack.Pop());
                    break;
                case "/":
                    double b = this.stack.Pop();
                    double a = this.stack.Pop();
                    if (Math.Abs(b) < Delta)
                    {
                        this.stack.Clear();
                        throw new DivideByZeroException();
                    }
                    
                    this.stack.Push(a / b);
                    break;
                default:
                    if (!Double.TryParse(elements[i], out double value))
                    {
                        this.stack.Clear();
                        throw new ArgumentException($"{elements[i]} is not double.");
                    }
                    
                    this.stack.Push(value);
                    break;
            }
        }

        if (this.stack.Size != 1)
        {
            this.stack.Clear();
            throw new ArgumentException("Expression is incorrect");
        }

        return this.stack.Pop();
    }
}
