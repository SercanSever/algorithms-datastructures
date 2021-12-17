
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

#region SinglyLinkedListResults

// using Algorithms.Datastructures.LinkedLists;
// using Algorithms.Datastructures.LinkedLists.Doubly;

// var singlyLinkedList = new SinglyLinkedList<int>();
// singlyLinkedList.AddFirst(1);
// singlyLinkedList.AddFirst(2);
// singlyLinkedList.AddFirst(3);
// // 3 2 1 <-- result

// singlyLinkedList.AddLast(4);
// singlyLinkedList.AddLast(5);
// // 3 2 1 4 5 <-- result

// singlyLinkedList.AddAfter(singlyLinkedList.Head.Next, 32);
// // 3 2 32 1 4 5 <-- result

// singlyLinkedList.RemoveFirst();
// // 2 32 1 4 5 <-- result
// singlyLinkedList.RemoveLast();
// // 2 32 1 4 <-- result
// singlyLinkedList.Remove(1);
// // 2 32 4 <-- result

// foreach (var item in singlyLinkedList)
// {
//    System.Console.WriteLine(item);
// }

#endregion

#region DounlyLinkedListResults
using Algorithms.Datastructures.LinkedLists.Doubly;

var doublyList = new DoublyLinkedList<int>();
doublyList.AddFirst(1);
doublyList.AddFirst(2);
// 2 1 <-- result

doublyList.AddLast(3);
doublyList.AddLast(4);
// 2 1 3 4 <-- result

doublyList.AddAfter(doublyList.Head.Next, new DoublyLinkedListNode<int>(5)
);
// 2 1 5 3 4 <-- result



#endregion


