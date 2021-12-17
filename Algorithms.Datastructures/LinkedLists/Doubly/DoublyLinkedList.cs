using System.Collections;

namespace Algorithms.Datastructures.LinkedLists.Doubly
{
   public class DoublyLinkedList<T> : IEnumerable
   {
      public DoublyLinkedListNode<T> Head { get; set; }
      public DoublyLinkedListNode<T> Tail { get; set; }
      private bool IsHeadNull => Head == null ? true : false;
      private bool IsTailNull => Tail == null ? true : false;

      public DoublyLinkedList(IEnumerable<T> collection)
      {
         foreach (var item in collection)
         {
            AddLast(item);
         }
      }

      public void AddFirst(T value)
      {
         var newNode = new DoublyLinkedListNode<T>(value);
         if (Head != null)
         {
            Head.Prev = newNode;
         }
         newNode.Next = Head;
         newNode.Prev = null;
         Head = newNode;

         if (Tail == null)
         {
            Tail = Head;
         }
      }
      public void AddLast(T value)
      {
         if (Tail == null)
         {
            AddFirst(value);
            return;
         }
         var newNode = new DoublyLinkedListNode<T>(value);

         Tail.Next = newNode;
         newNode.Next = null;
         newNode.Prev = Tail;
         Tail = newNode;
         return;
      }

      public void AddAfter(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
      {
         if (refNode == null)
         {
            throw new ArgumentNullException();
         }
         if (refNode == Head && refNode == Tail)
         {
            refNode.Next = newNode;
            refNode.Prev = null;
            newNode.Prev = refNode;
            newNode.Next = null;

            Head = refNode;
            Tail = newNode;
            return;
         }

         if (refNode != Tail)
         {
            newNode.Prev = refNode;
            newNode.Next = refNode.Next;
            refNode.Next.Prev = newNode;
            refNode.Next = newNode;
         }
         else
         {
            newNode.Prev = refNode;
            newNode.Next = null;
            refNode.Next = newNode;
            Tail = newNode;
         }
      }

      public object ToList()
      {
         throw new NotImplementedException();
      }

      public void AddBefore(DoublyLinkedListNode<T> refNode, DoublyLinkedListNode<T> newNode)
      {
         if (refNode == null)
         {
            throw new ArgumentNullException();
         }
         if (refNode == Head && refNode == Tail)
         {
            refNode.Prev = newNode;
            refNode.Next = null;
            newNode.Prev = null;
            newNode.Next = refNode;

            Head = newNode;
            Tail = refNode;
            return;
         }

         if (refNode != Head)
         {
            newNode.Next = refNode;
            newNode.Prev = refNode.Prev;
            refNode.Prev.Next = newNode;
            refNode.Prev = newNode;
         }
         else
         {
            newNode.Next = refNode;
            newNode.Prev = newNode;
            refNode.Next = null;
            Head = newNode;
         }
      }

      private List<DoublyLinkedListNode<T>> GetAllNodes()
      {
         var list = new List<DoublyLinkedListNode<T>>();

         var current = Head;
         while (current.Next != null)
         {
            list.Add(current);
            current = current.Next;
         }
         return list;
      }

      public IEnumerator GetEnumerator()
      {
         return GetAllNodes().GetEnumerator();
      }

      public T RemoveFirst()
      {
         if (IsHeadNull)
         {
            throw new ArgumentNullException();
         }
         var temp = Head.Value;
         if (Head == Tail)
         {
            Head = null;
            Tail = null;
         }
         else
         {
            Head = Head.Next;
            Head.Prev = null;
         }
         return temp;
      }

      public T RemoveLast()
      {
         if (IsTailNull)
         {
            throw new ArgumentNullException();
         }
         var temp = Tail.Value;
         if (Tail == Head)
         {
            Head = null;
            Tail = null;
         }
         else
         {
            Tail.Prev.Next = null;
            Tail = Tail.Prev;
         }
         return temp;
      }

      public T Remove(T value)
      {
         if (IsHeadNull)
         {
            throw new ArgumentNullException();
         }
         var temp = Tail.Value;
         if (Head == Tail)
         {
            if (Head.Value.Equals(value))
            {
               RemoveFirst();
            }
         }

         var current = Head;
         while (current != null)
         {
            if (current.Value.Equals(value))
            {
               if (current.Prev == null)
               {
                  current.Next.Prev = null;
                  Head = current.Next;
               }
               else if (current.Next == null)
               {
                  current.Prev.Next = null;
                  Tail = current.Prev;
               }
               else
               {
                  current.Next.Prev = current.Prev;
                  current.Prev.Next = current.Next;
               }
               break;
            }
            else
            {
               throw new ArgumentException();
            }
         }


         return temp;
      }




   }
}