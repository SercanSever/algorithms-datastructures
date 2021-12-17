namespace Algorithms.Datastructures.LinkedLists
{
   public class SinglyLinkedListNode<T>
   {
      public SinglyLinkedListNode<T> Next { get; set; }
      public SinglyLinkedListNode<T> Previous { get; set; }
      public T Value { get; set; }

      public SinglyLinkedListNode(T value)
      {
         Value = value;
      }

      public override string ToString() => $"{Value}";
   }
}