using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_UniqueList;

internal class UniqueList : MyList
{
    public override void AddValue(int value, int index)
    {
        if (base.Contains(value))
            throw new ArgumentException();

        base.AddValue(value, index);
    }

    public override void SetValue(int value, int index)
    {
        int i = FindIndexByValue(value);
        if (i >= 0)
        {
            if (i != index)
            {
                throw new ArgumentException();
            }
            else
            {
                return;
            }
        }

        base.SetValue(value, index);
    }
}
