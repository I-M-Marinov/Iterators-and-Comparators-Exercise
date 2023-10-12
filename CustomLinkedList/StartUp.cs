using CustomDoublyLinkedList;

CustomDoublyLinkedList<int> list = new();

list.AddFirst(3);
list.AddFirst(2);
list.AddFirst(1);
list.AddLast(4);

Console.WriteLine($"First removed: {list.RemoveFirst()}");
Console.WriteLine($"Last removed: {list.RemoveLast()}");

int[] arr = list.ToArray();

list.ForEach(i => Console.Write($"{i} "));
Console.WriteLine();
Console.WriteLine(list.Count);

CustomDoublyLinkedList<string> stringList = new();

stringList.AddFirst("sometimes");
stringList.AddFirst("play");
stringList.AddFirst("sometimes");
stringList.AddLast("lun");

stringList.ForEach(i => Console.Write($"{i} "));
Console.WriteLine();
Console.WriteLine(stringList.Count);

Console.WriteLine($"First removed: {stringList.RemoveFirst()}");
Console.WriteLine($"Last removed: {stringList.RemoveLast()}");

stringList.ForEach(i => Console.Write($"{i} "));
Console.WriteLine();
Console.WriteLine(stringList.Count);

foreach (var item in list)
{
    Console.WriteLine(item);
}

