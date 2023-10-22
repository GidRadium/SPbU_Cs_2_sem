using Task04StackCalculator;

Console.WriteLine("Enter the expression:");
string input = Console.ReadLine() ?? "";
if (input == "")
{
    Console.WriteLine("Incorrect input!");
    return;
}

var arrayStackCalculator = new StackCalculator(new ArrayStack());
var listStackCalculator = new StackCalculator(new ListStack());

try
{
    Console.WriteLine($"arrayStackCalculator result is {arrayStackCalculator.Solve(input)}");
    Console.WriteLine($"listStackCalculator result is {listStackCalculator.Solve(input)}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by 0.");
}
catch (ArgumentException e)
{
    Console.WriteLine(e.ToString());
}
