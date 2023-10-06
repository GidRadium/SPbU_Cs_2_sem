namespace Task_06_ParseTree;

public class Program
{
    static void Main()
    {
        var tree = new ParseTree("(* (+ 1 1) 2)");
        Console.WriteLine(tree);
    }
}
