using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");

        var set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        var set2 = new HashSet<int> { 4, 5, 6, 7, 8 , 9 };
    
        var intersection = new List<int>();
        var union = new List<int>(set1);

        // INTERSECTION
        foreach (var item in set1)
        {
            if(set2.Contains(item))
            {
                intersection.Add(item);
            }
        }
        // UNION
        foreach (var item in set2)
        {
            if(!set1.Contains(item))
            {
                union.Add(item);
            }
        }

        Console.WriteLine("-----");
        intersection.ForEach(i => Console.Write(i));
        Console.WriteLine("-----");
        union.ForEach(u => Console.Write(u));
    }
}