using Task01Sorting;

Console.WriteLine("Enter numbers separated by spaces:");
string input = Console.ReadLine() ?? "";
input = input.Trim();
var inputSplitted = input.Split(' ');
var array = new int[inputSplitted.Length];

for (int i = 0; i < inputSplitted.Length; i++)
{
    if (!int.TryParse(inputSplitted[i], out array[i]))
    {
        Console.WriteLine("Input is incorrect!");
        return;
    }
}

Sorting.BubbleSort(array);

foreach (var item in array)
    Console.Write($"{item} ");
