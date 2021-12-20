namespace Algorithms.Datastructures.Stacks
{
   public class ArrayStack<T> : IStackService<T>
   {
      public int Count { get; private set; }
      private readonly List<T> list = new();

      public void Clear()
      {
         list.Clear();
      }

      public T Peek()
      {
         return list[list.Count - 1];
      }

      public T Pop()
      {
         if (Count == 0) return default(T);
         var temp = list[list.Count - 1];
         list.RemoveAt(list.Count - 1);
         Count--;
         return temp;
      }

      public void Push(T value)
      {
         if (value == null)
            throw new ArgumentNullException();
         list.Add(value);
         Count++;
      }
   }
}