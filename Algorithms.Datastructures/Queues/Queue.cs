namespace Algorithms.Datastructures.Queues
{
   public class Queue<T>
   {
      private readonly IQueueService<T> _queueService;
      public Queue(QueueType type = QueueType.Array)
      {
         if (type == QueueType.Array)
         {
            _queueService = new ArrayQueue<T>();
         }
         else
         {
            _queueService = new LinkedListQueue<T>();
         }
      }

      public void EnQueue(T value)
      {
         _queueService.EnQueue(value);
      }
      public T DeQueue()
      {
         return _queueService.Dequeue();
      }
      public T Peek()
      {
         return _queueService.Peek();
      }
   }
   public enum QueueType
   {
      Array = 0,
      LinkedList = 1
   }
}