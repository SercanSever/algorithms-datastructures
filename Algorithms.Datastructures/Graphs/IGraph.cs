namespace Algorithms.Datastructures.Graphs
{
   public interface IGraph<T> : IEnumerable<T>
   {
      bool IsWeightedGraph { get; }
      int Count { get; }
      IGraphVertex<T> ReferenceVertex { get; }
      IEnumerable<IGraphVertex<T>> VerticeAsEnumerable { get; }
      IEnumerable<T> Edges(T key);
      IGraph<T> Clone();
      bool ContainsVertex(T key);
      IGraphVertex<T> GetVertex(T key);
      bool HasEdge(T source, T destination);
      void AddVertex(T key);
      void RemoveVertex(T key);
      void RemoveEdge(T source, T destination);
   }
   public interface IGraphVertex<T> : IEnumerable<T>
   {
      T Key { get; }
      IEnumerable<IEdge<T>> Edges { get; }
      IEdge<T> GetEdge(IGraphVertex<T> targetVertex);
   }
   public interface IEdge<T>
   {
      T TargetVertexKey { get; }
      IGraphVertex<T> TargetVertex { get; }
      W Weight<W>() where W : IComparable;
   }
}