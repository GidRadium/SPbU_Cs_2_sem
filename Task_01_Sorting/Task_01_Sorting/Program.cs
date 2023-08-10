using System;

namespace Task_01
{
    class Sorting
    {
        static void Main()
        {

            Console.WriteLine("Enter numbers separated by spaces:");
            string input;
            int[] array;
            while (true)
            {
                try
                {
                    input = Console.ReadLine() ?? "";
                    array = input.Split(' ').Select(int.Parse).ToArray();
                    break;
                }
                catch 
                {
                    Console.WriteLine("Incorrect input!");
                }
            }

            BubbleSort(array);

            foreach (var item in array)
                Console.Write($"{item} ");
        }

        static int[] BubbleSort(int[] array)
        {
            if (array.Length < 2) 
                return array;

            for (int k = 0; k < array.Length; k++)
                for (int i = 0; i < array.Length - 1; i++)
                    if (array[i] > array[i + 1])
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);

            return array;
        }
    }
}
