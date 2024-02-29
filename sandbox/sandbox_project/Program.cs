using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");

        List<int> list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

        List<int> list2 = list.GetRange(0, 3);

        list.RemoveRange(0, 3);

        list.AddRange(list2);

        Console.WriteLine("----------------");
        foreach (var item in list)
        {
            Console.Write($"{item}, ");
        }
    }
}