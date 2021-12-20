using Algorithms.Datastructures.LinkedLists;

namespace Algorithms.Datastructures.Stacks
{
   public class LinkedListStack<T> : IStackService<T>
   {
      private readonly SinglyLinkedList<T> list = new();
      public int Count { get; private set; }
      public T Peek()
      {
         if (Count == 0)
            new ArgumentNullException();
         return list.Head.Value;
      }

      public T Pop()
      {
         if (Count == 0)
            new ArgumentNullException();
         var temp = list.Head.Value;
         list.RemoveFirst();
         Count--;
         return temp;
      }

      public void Push(T value)
      {
         if (value == null)
            new ArgumentNullException();
         list.AddFirst(value);
         Count++;
      }
   }
}