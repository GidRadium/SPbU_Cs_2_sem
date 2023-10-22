using System;


namespace Task_04_StackCalculator
{
    public class Task_04_StackCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter the expression:");
            string input = Console.ReadLine() ?? throw new Exception("Incorrect input.");
            var arrayStackCalculator = new StackCalculator(new ArrayStack());
            var listStackCalculator = new StackCalculator(new ListStack());
            try
            {
                Console.WriteLine($"arrayStackCalculator result is {arrayStackCalculator.Solve(input)}");
                Console.WriteLine($"listStackCalculator result is {listStackCalculator.Solve(input)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
