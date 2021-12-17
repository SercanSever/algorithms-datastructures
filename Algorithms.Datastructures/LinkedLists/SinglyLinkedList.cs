using System.Collections;

namespace Algorithms.Datastructures.LinkedLists
{
   public class SinglyLinkedList<T> : IEnumerable<T>
   {

      public SinglyLinkedListNode<T> Head { get; set; }
      public SinglyLinkedListNode<T> Prev { get; set; }

      public void AddFirst(T value)
      {
         var newNode = new SinglyLinkedListNode<T>(value);
         newNode.Next = Head;
         Head = newNode;
      }
      public void AddLast(T value)
      {
         var newNode = new SinglyLinkedListNode<T>(value);
         if (Head == null)
         {
            Head = newNode;
            return;
         }

         var current = Head;
         while (current.Next != null)
         {
            current = current.Next;
         }
         current.Next = newNode;
      }

      public void AddAfter(SinglyLinkedListNode<T> node, T value)
      {
         var newNode = new SinglyLinkedListNode<T>(value);
         var current = Head;
         while (current != null)
         {
            if (current.Equals(node))
            {
               newNode.Next = current.Next;
               current.Next = newNode;
               return;
            }
            current = current.Next;
         }
         throw new ArgumentException("The reference node is not in the list.");
      }

      public T RemoveFirst()
      {
         var firstValue = Head.Value;
         Head = Head.Next;
         return firstValue;
      }
      public T RemoveLast()
      {
         var current = Head;
         while (current.Next != null)
         {
            Prev = current;
            current = current.Next;
         }
         Prev.Next = null;
         return Prev.Next.Value;
      }



      public IEnumerator<T> GetEnumerator()
      {
         return new SinglyLinkedListEnumerator<T>(Head);
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}