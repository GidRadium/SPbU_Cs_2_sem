namespace Task04StackCalculator;

public class StackCalculator
{
    public const double Delta = 0.000001;
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
                    if (Math.Abs(b) < Delta)
                    {
                        while (this.Stack.Size > 0)
                            Stack.Pop();
                        throw new DivideByZeroException();
                    }
                    
                    this.Stack.Push(a / b);
                    break;
                default:
                    double value;
                    if (!Double.TryParse(elements[i], out value))
                    {
                        while (this.Stack.Size > 0)
                            Stack.Pop();
                        throw new ArgumentException($"{elements[i]} is not double.");
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
