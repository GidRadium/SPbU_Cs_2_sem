﻿namespace Task02BurrowsWheelerTransform;

public class BurrowsWheelerTransform
{
    public static (string, int) Encode(string input)
    {
        if (input.Length == 0)
            return (input, -1);

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

        return (encoded, index);
    }

    public static string Decode(string encoded, int index)
    {
        if (encoded.Length == 0)
            return encoded;

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
