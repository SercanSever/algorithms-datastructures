namespace Algorithms.Datastructures.Queues
{
   public class ArrayQueue<T> : IQueueService<T>
   {
      private readonly List<T> list = new();
      public int Count { get; private set; }

      public T Dequeue()
      {
         if (Count == 0)
            throw new ArgumentException();
         var temp = list[0];
         list.RemoveAt(0);
         Count--;
         return temp;
      }

      public void EnQueue(T value)
      {
         if (value == null)
         {
            throw new ArgumentNullException();
         }
         list.Add(value);
         Count++;
      }

      public T Peek()
      {
         if (Count == 0)
            throw new ArgumentException();
         return list[0];
      }
   }
}