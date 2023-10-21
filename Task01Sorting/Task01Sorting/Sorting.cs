namespace Task01Sorting;
public class Sorting
{
    public static int[] BubbleSort(int[] array)
    {
        if (array == null) 
            throw new ArgumentNullException();

        if (array.Length < 2)
            return array;

        for (int k = 0; k < array.Length; k++)
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1])
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);

        return array;
    }
}
