using Task06ParseTree;

Console.WriteLine("Enter file with expression path:");
string filePath = Console.ReadLine() ?? string.Empty;
if (!File.Exists(filePath))
{
    Console.WriteLine($"Can't open file {filePath}");
    return;
}

string input;
using (var file = new System.IO.StreamReader(filePath))
{
    input = file.ReadToEnd();
}

input = input.Trim();
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
catch(Exception ex)
{
    Console.WriteLine($"Undefined exception is catched:\n{ex.Message}");
    return;
}
        
Console.WriteLine(tree);

try
{
    Console.WriteLine($"Result of solving expression: {tree.Calculate()}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Expression contains dividing by 0");
    return;
}
catch (Exception ex)
{
    Console.WriteLine($"Undefined exception is catched:\n{ex.Message}");
    return;
}
