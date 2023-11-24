namespace Task10MapFilterFold;

// Some useful functions for data processing.
static public class MyFunctions
{
    // Returns a list obtained by applying the passed function to each element of the passed list.
    public static List<TOut> Map<TIn, TOut>(List<TIn> list, Func<TIn, TOut> mapFunction)
    {
        var output = new List<TOut>();
        foreach (var item in list)
            output.Add(mapFunction(item));

        return output;
    }

    // Returns a list made up of those elements of the passed list for which the passed function returned true.
    public static List<TIn> Filter<TIn>(List<TIn> list, Func<TIn, bool> filterFunction)
    {
        var output = new List<TIn>();
        foreach (var item in list)
            if (filterFunction(item))
                output.Add(item);

        return output;
    }

    // Returns the accumulated value obtained after the entire list has been passed through.
    public static TOut Fold<TIn, TOut>(List<TIn> list, TOut startValue, Func<TIn, TOut, TOut> foldFunction)
    {
        var output = startValue;
        foreach (var item in list)
            output = foldFunction(item, output);

        return output;
    }
}
