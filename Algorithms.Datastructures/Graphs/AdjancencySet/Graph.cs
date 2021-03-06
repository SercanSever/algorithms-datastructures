using System.Collections;
using System.Linq;

namespace Algorithms.Datastructures.Graphs.AdjancencySet
{
   public class Graph<T> : IGraph<T>
   {
      private class GraphVertex<T> : IGraphVertex<T>
      {
         public T Key { get; set; }
         public HashSet<GraphVertex<T>> Edges { get; private set; }
         public GraphVertex(T key)
         {
            Key = key;
         }

         IEnumerable<IEdge<T>> IGraphVertex<T>.Edges => Edges.Select(x => new Edge<T, int>(x, 1));

         public IEdge<T> GetEdge(IGraphVertex<T> targetVertex)
         {
            return new Edge<T, int>(targetVertex, 1);
         }

         public IEnumerator<T> GetEnumerator()
         {
            throw new NotImplementedException();
         }

         IEnumerator IEnumerable.GetEnumerator()
         {
            throw new NotImplementedException();
         }
      }

      public bool IsWeightedGraph => throw new NotImplementedException();

      public int Count => throw new NotImplementedException();

      public IGraphVertex<T> ReferenceVertex => throw new NotImplementedException();

      public IEnumerable<IGraphVertex<T>> VerticeAsEnumerable => throw new NotImplementedException();

      public void AddVertex(T key)
      {
         throw new NotImplementedException();
      }

      public IGraph<T> Clone()
      {
         throw new NotImplementedException();
      }

      public bool ContainsVertex(T key)
      {
         throw new NotImplementedException();
      }

      public IEnumerable<T> Edges(T key)
      {
         throw new NotImplementedException();
      }

      public IEnumerator<T> GetEnumerator()
      {
         throw new NotImplementedException();
      }

      public IGraphVertex<T> GetVertex(T key)
      {
         throw new NotImplementedException();
      }

      public bool HasEdge(T source, T destination)
      {
         throw new NotImplementedException();
      }

      public void RemoveEdge(T source, T destination)
      {
         throw new NotImplementedException();
      }

      public void RemoveVertex(T key)
      {
         throw new NotImplementedException();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         throw new NotImplementedException();
      }
   }
}