using Task13SkipList;

var list = new SkipList<int>();

list.Add(0);
list[1] = 1;
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Remove(4);
list.RemoveAt(2);
list.Insert(6, 6);

int summ = 0;
foreach (var item in list)
    summ += item;

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine(summ);
