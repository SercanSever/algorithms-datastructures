namespace Algorithms.Datastructures.Stacks
{
   public interface IStackService<T>
   {
      void Push(T value);
      T Peek();
      T Pop();
      int Count { get; }
      void Clear();
   }
}