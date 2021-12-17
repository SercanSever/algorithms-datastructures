
#region ArrayResults

// var arr = new Algorithms.Datastructures.Arrays.Array<int>();
// arr.Add(23);
// arr.Add(55);
// arr.Add(2);
// arr.Add(2);
// arr.Add(2);

// System.Console.WriteLine($"{arr.Count} - {arr.Capacity}");

// arr.ToList().ForEach(x =>
// {
//    System.Console.WriteLine(x);
// });
#endregion

#region LinkedListResults

using Algorithms.Datastructures.LinkedLists;

var singlyLinkedList = new SinglyLinkedList<int>();
singlyLinkedList.AddFirst(1);
singlyLinkedList.AddFirst(2);
singlyLinkedList.AddFirst(3);

singlyLinkedList.AddLast(4);
singlyLinkedList.AddLast(5);
// 3 2 1 4 5 <-- result
System.Console.WriteLine();

#endregion