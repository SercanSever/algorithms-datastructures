namespace Algorithms.Datastructures.Stacks
{
   public class Stack<T>
   {
      private readonly IStackService<T> _stackService;
      public int Count => _stackService.Count;
      public Stack(StackType type = StackType.Array) //default
      {
         if (type == StackType.Array)
         {
            _stackService = new ArrayStack<T>();
         }
         else
         {
            _stackService = new LinkedListStack<T>();
         }
      }
      public T Pop()
      {
         return _stackService.Pop();
      }
      public T Peek()
      {
         return _stackService.Peek();
      }
      public void Push(T value)
      {
         _stackService.Push(value);
      }
   }

   public enum StackType
   {
      Array = 0,
      LinkedList = 1
   }
}