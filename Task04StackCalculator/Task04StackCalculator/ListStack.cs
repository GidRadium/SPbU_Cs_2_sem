namespace Task04StackCalculator;

public class ListStack : IStack
{
    private List<double> data;

    public ListStack()
        => this.data = new List<double>();

    public int Size { get; private set; }

    public void Push(double value)
    {
        this.data.Add(value);
        this.Size++;
    }

    public double Pop()
    {
        if (this.Size == 0)
            throw new Exception("ListStack.Pop(): Stack is empty!");

        double result = this.data[this.Size - 1];
        this.data.RemoveAt(this.Size - 1);
        this.Size--;
        return result;
    }

    public double Top()
    {
        if (this.Size == 0)
            throw new Exception("ListStack.Top(): Stack is empty!");

        return this.data[this.Size - 1];
    }
}
