namespace Algorithms.Datastructures.SortingAlgorithms
{
   public class Insertion
   {
      public static void Sort<T>(T[] array) where T : IComparable
      {
         for (var i = 1; i < array.Length; i++)
         {
            var val = array[i];
            var flag = 0;
            for (var j = i - 1; j >= 0 && flag != 1; j--)
            {
               if (val.CompareTo(array[j]) < 0)
               {
                  Sorting.Swap<T>(array, j, j + 1);
                  //   array[j + 1] = array[j];
                  //   j--;
                  //   array[j + 1] = val;
               }
               else flag = 1;
            }
         }
      }
   }
}