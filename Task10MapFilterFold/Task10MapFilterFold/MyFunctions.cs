namespace Task10MapFilterFold;

public class MyFunctions
{
    public static List<TOut> Map<TIn, TOut>(List<TIn> list, Func<TIn, TOut> mapFunction)
    {
        var output = new List<TOut>();
        foreach (var item in list)
            output.Add(mapFunction(item));

        return output;
    }

    public static List<TIn> Filter<TIn>(List<TIn> list, Func<TIn, bool> filterFunction)
    {
        var output = new List<TIn>();
        foreach (var item in list)
            if (filterFunction(item))
                output.Add(item);

        return output;
    }

    public static TOut Fold<TIn, TOut>(List<TIn> list, TOut startValue, Func<TIn, TOut, TOut> foldFunction)
    {
        var output = startValue;
        foreach (var item in list)
            output = foldFunction(item, output);

        return output;
    }
}
