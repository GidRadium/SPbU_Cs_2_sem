namespace Task04StackCalculator;

public class ArrayStack : IStack
{
    private double[] data;

    public ArrayStack()
        => this.data = new double[2];

    public int Size { get; private set; }

    public void Push(double value)
    {
        if (this.data.Length == this.Size)
            Array.Resize(ref this.data, this.Size * 2);

        this.data[this.Size] = value;
        this.Size++;
    }

    public double Pop()
    {
        if (this.Size == 0)
            throw new Exception("ArrayStack.Pop(): Stack is empty!");

        this.Size--;
        return this.data[this.Size];
    }

    public double Top()
    {
        if (this.Size == 0)
            throw new Exception("ArrayStack.Top(): Stack is empty!");

        return this.data[this.Size - 1];
    }
}
