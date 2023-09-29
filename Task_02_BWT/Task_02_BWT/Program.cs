using System;
using System.Text;

namespace Task_02_BWT;

class BWT
{
    static void Main()
    {
        Console.WriteLine("Enter the string: ");
        string input;
        while (true)
        {
            input = Console.ReadLine() ?? "";
            if (input == "")
                Console.WriteLine("Incorrect Input!");
            else
                break;
        }

        Tuple<string, int> encoded = Encode(input);
        string decoded = Decode(encoded.Item1, encoded.Item2);
        Console.WriteLine($"Input:   {input}");
        Console.WriteLine($"Encoded: {encoded.Item1} {encoded.Item2}");
        Console.WriteLine($"Decoded: {decoded}");
    }

    public static Tuple<string, int> Encode(string input)
    {
        var size = input.Length;
        var table = new string[size];
        table[size - 1] = input;

        string temp = input;
        for (int i = 0; i < size - 1; i++)
        {
            temp = temp[size - 1] + temp.Substring(0, size - 1);
            table[i] = temp;
        }

        Array.Sort(table);
        string encoded = "";
        int index = 0;

        for (int i = 0; i < size; i++)
        {
            encoded += table[i][size - 1];
            if (table[i] == input)
                index = i;
        }

        return Tuple.Create(encoded, index);
    }

    public static string Decode(string encoded, int index)
    {
        int size = encoded.Length;
        var table = new List<string>();
        for (int i = 0; i < size; i++)
            table.Add(Char.ToString(encoded[i]));

        table.Sort();
        while (table[0].Length != size)
        {
            for (int i = 0; i < size; i++)
                table[i] = encoded[i] + table[i];
            table.Sort();
        }

        return table[index];
    }
}
