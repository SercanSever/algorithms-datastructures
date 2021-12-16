var arr = new Algorithms.Datastructures.Arrays.Array<int>();
arr.Add(23);
arr.Add(55);
arr.Add(2);
arr.Add(2);
arr.Add(2);

System.Console.WriteLine($"{arr.Count} - {arr.Capacity}");

arr.ToList().ForEach(x =>
{
   System.Console.WriteLine(x);
});
