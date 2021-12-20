using Algorithms.Datastructures.LinkedLists.Doubly;

namespace Algorithms.Datastructures.Queues
{
   public class LinkedListQueue<T> : IQueueService<T>
   {
      private readonly DoublyLinkedList<T> list = new();
      public int Count { get; private set; }
      public T Dequeue()
      {
         if (Count == 0)
            throw new ArgumentException();
         var temp = list.RemoveFirst();
         Count--;
         return temp;

      }

      public void EnQueue(T value)
      {
         if (value == null)
            throw new ArgumentNullException();
         list.AddLast(value);
         Count++;
      }

      public T Peek() => Count == 0
      ? throw new ArgumentException()
      : list.Head.Value;
   }
}