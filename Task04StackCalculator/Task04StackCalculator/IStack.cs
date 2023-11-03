namespace Task04StackCalculator;

public interface IStack
{
    public int Size { get; }

    void Push(double value);

    double Pop();

    double Top();

    void Clear();
}
