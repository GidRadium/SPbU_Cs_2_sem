namespace Task07UniqueList;

/// <summary>
/// List that prohibits containing duplicate elements.
/// </summary>
public class UniqueList : MyList
{
    /// <summary>
    /// Inserts value to the list to the index position.
    /// Throws AddRepeatingElementToUniqueListException if element repeats.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="AddRepeatingElementToUniqueListException"></exception>
    public override void AddValue(int value, int index)
    {
        if (base.Contains(value))
            throw new AddRepeatingElementToUniqueListException();

        base.AddValue(value, index);
    }

    /// <summary>
    /// Sets the value to the index position.
    /// Throws AddRepeatingElementToUniqueListException if element repeats.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="AddRepeatingElementToUniqueListException"></exception>
    public override void SetValue(int value, int index)
    {
        int i = FindIndexByValue(value);
        if (i >= 0)
        {
            if (i != index)
                throw new AddRepeatingElementToUniqueListException();
            else
                return;
        }

        base.SetValue(value, index);
    }
}
