namespace Algorithms.Datastructures.Graphs
{
   public class Edge<T, C> : IEdge<T>
   where C : IComparable
   {
      private object _weight;
      public Edge(IGraphVertex<T> target, C weight)
      {
         TargetVertex = target;
         _weight = weight;
      }

      public T TargetVertexKey => TargetVertex.Key;

      public IGraphVertex<T> TargetVertex { get; private set; }

      public W Weight<W>() where W : IComparable
      {
         return (W)_weight;
      }
      public override string ToString()
      {
         return TargetVertexKey.ToString();
      }
   }
}