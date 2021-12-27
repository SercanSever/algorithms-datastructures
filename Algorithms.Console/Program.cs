
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
// using Algorithms.Datastructures.LinkedLists.Doubly;

// var doublyList = new DoublyLinkedList<int>();
// doublyList.AddFirst(1);
// doublyList.AddFirst(2);
// // 2 1 <-- result

// doublyList.AddLast(3);
// doublyList.AddLast(4);
// // 2 1 3 4 <-- result

// doublyList.AddAfter(doublyList.Head.Next, new DoublyLinkedListNode<int>(5)
// );
// // 2 1 5 3 4 <-- result

// doublyList.AddBefore(doublyList.Head.Next, new DoublyLinkedListNode<int>(10));
// // 2 10 1 5 3 4 <-- result

// foreach (var item in doublyList)
// {
//    System.Console.WriteLine(item);
// }

#endregion

#region BinarySearchTree

// using Algorithms.Datastructures.Trees.BinarySearchTree;
// using Algorithms.Datastructures.Trees.BinaryTree;

// var bst = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });

// var bt = new BT<int>();
// bt.InOrder(bst.Root).ForEach(node => System.Console.WriteLine(node + " "));

// // new BT<int>().PreOrder(bst.Root).ForEach(node => System.Console.WriteLine(node + " "));

// // new BT<int>().PostOrder(bst.Root).ForEach(node => System.Console.WriteLine(node + " "));
// BT<int>.MaxDepth(bst.Root);

// Console.ReadKey();
#endregion

#region BinaryHeap

//MINHEAP
// using Algorithms.Datastructures.Heap;

// var minHeap = new MinHeap<int>(new int[] { 4, 1, 10, 8, 7, 5, 9, 3 });

// foreach (var item in minHeap)
// {
//    System.Console.WriteLine(item);
// }
// Console.ReadKey();

//MAXHEAP
// using Algorithms.Datastructures.Heap;

// var maxHeap = new MaxHeap<int>(new int[] { 15, 2, 25, 30, 50, 5, 8, 1 });

// foreach (var item in maxHeap)
// {
//    System.Console.WriteLine(item);
// }
// Console.ReadKey();


#endregion

#region SortingAlgorithms
using Algorithms.Datastructures.SortingAlgorithms;

//SELECTİON
var array = new int[] { 15, 4, 2, 8, 1, 415 };
foreach (var item in array)
{
   System.Console.WriteLine($"{item,-5}");
}

Selection.Sort<int>(array);
System.Console.WriteLine("------------------------------");
System.Console.WriteLine("Selection");
foreach (var item in array)
{
   System.Console.WriteLine($"{item,-5}");
}

//BUBBLE

Bubble.Sort<int>(array);
System.Console.WriteLine("------------------------------");
System.Console.WriteLine("Bubble");
foreach (var item in array)
{
   System.Console.WriteLine($"{item,-5}");
}

//Insertion

Insertion.Sort<int>(array);
System.Console.WriteLine("------------------------------");
System.Console.WriteLine("Insertion");
foreach (var item in array)
{
   System.Console.WriteLine($"{item,-5}");
}

//Quick
Quick.Sort<int>(array);
System.Console.WriteLine("------------------------------");
System.Console.WriteLine("Quick");
foreach (var item in array)
{
   System.Console.WriteLine($"{item,-5}");
}

//MERGE
Merge.Sort<int>(array);
System.Console.WriteLine("------------------------------");
System.Console.WriteLine("Merge");
foreach (var item in array)
{
   System.Console.WriteLine($"{item,-5}");
}


#endregion

