using System;

namespace Task_01
{
    class Sorting
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            int[] array =  input.Split(' ').Select(int.Parse).ToArray();

            BubbleSort(array);

            foreach (var item in array)
                Console.Write($"{item} ");

        }

        static int[] BubbleSort(int[] array)
        {
            return array;
        }
    }
}