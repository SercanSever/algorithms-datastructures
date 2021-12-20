namespace Algorithms.Datastructures.Queues
{
   public interface IQueueService<T>
   {
      void EnQueue(T value);
      T Dequeue();
      int Count { get; }
      T Peek();
   }
}