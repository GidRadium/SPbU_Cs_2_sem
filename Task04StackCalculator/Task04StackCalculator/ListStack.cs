namespace Task04StackCalculator;

public class ListStack : IStack
{
    private List<double> data = new();

    public int Size => this.data.Count;

    public void Push(double value)
        => this.data.Add(value);

    public double Pop()
    {
        if (this.Size == 0)
            throw new InvalidOperationException("Stack is empty!");

        double result = this.data[this.Size - 1];
        this.data.RemoveAt(this.Size - 1);
        return result;
    }

    public double Top()
    {
        if (this.Size == 0)
            throw new InvalidOperationException("Stack is empty!");

        return this.data[this.Size - 1];
    }

    public void Clear()
        => this.data.Clear();
}
