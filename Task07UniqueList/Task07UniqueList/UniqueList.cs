namespace Task07UniqueList;

public class UniqueList : MyList
{
    public override void AddValue(int value, int index)
    {
        if (base.Contains(value))
            throw new AddRepeatingElementToUniqueListException();

        base.AddValue(value, index);
    }

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
