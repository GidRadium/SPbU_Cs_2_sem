using Task13SkipList;

var list = new SkipList<int>();

list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.RemoveAt(4);

foreach (var item in list)
{
    Console.WriteLine(item);
}
