using Algorithms.Datastructures.Queues;
using Algorithms.Datastructures.Trees.BT;

namespace Algorithms.Datastructures.Trees.BinaryTree
{
   public class BT<T> where T : IComparable
   {
      public List<Node<T>> list { get; private set; }
      public BT()
      {
         list = new List<Node<T>>();
      }
      public List<Node<T>> InOrder(Node<T> root)
      {
         if (!(root == null))
         {
            InOrder(root.Left);
            list.Add(root);
            InOrder(root.Right);
         }
         return list;
      }
      public List<Node<T>> PreOrder(Node<T> root)
      {
         if (!(root == null))
         {
            list.Add(root);
            PreOrder(root.Left);
            PreOrder(root.Right);
         }
         return list;
      }
      public List<Node<T>> PostOrder(Node<T> root)

      {
         if (!(root == null))
         {
            PostOrder(root.Left);
            PostOrder(root.Right);
            list.Add(root);
         }
         return list;
      }

      public Node<T> FindMin(Node<T> root)
      {
         var current = root;
         while (!(current.Left == null))
         {
            current = current.Left;
         }
         return current;
      }
      public Node<T> FindMax(Node<T> root)
      {
         var current = root;
         while (!(current.Right == null))
         {
            current = current.Right;
         }
         return current;
      }

      public Node<T> Find(Node<T> root, T value)
      {
         var current = root;
         while (value.CompareTo(current.Value) != 0)
         {
            if (value.CompareTo(current.Value) < 0)
            {
               current = current.Left;
            }
            else
            {
               current = current.Right;
            }
            if (current == null)
            {
               throw new ArgumentException();
            }
         }
         return current;
      }

      public Node<T> Remove(Node<T> root, T value)
      {
         if (root == null)
         {
            return root;
         }

         if (value.CompareTo(root.Value) < 0)
         {
            root.Left = Remove(root.Left, value);
         }
         else if (value.CompareTo(root.Value) > 0)
         {
            root.Right = Remove(root.Right, value);
         }
         else
         {
            if (root.Left == null)
            {
               return root.Right;
            }
            else if (root.Right == null)
            {
               return root.Left;
            }

            root.Value = FindMax(root.Right).Value;
            root.Right = Remove(root.Right, root.Value);
         }
         return root;
      }

      public static int MaxDepth(Node<T> root)
      {
         if (root == null)
         {
            return 0;
         }
         int leftDepth = MaxDepth(root.Left);
         int rightDepth = MaxDepth(root.Right);

         return (leftDepth > rightDepth) ? leftDepth + 1 : rightDepth + 1;
      }

   }
}