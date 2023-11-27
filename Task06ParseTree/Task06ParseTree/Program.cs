using Task06ParseTree;

Console.WriteLine("Enter file with expression path:");
string filePath = Console.ReadLine() ?? string.Empty;
if (!File.Exists(filePath))
{
    Console.WriteLine($"Can't open file {filePath}");
    return;
}

string input = File.ReadAllText(filePath).Trim();

ParseTree tree;
try
{
    tree = new ParseTree(input);
}
catch (IncorrectExpressionException)
{
    Console.WriteLine($"Expression in file {filePath} is incorrect!");
    return;
}

Console.WriteLine(tree);

try
{
    Console.WriteLine($"Result of solving expression: {tree.Count()}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Expression contains dividing by 0");
}
