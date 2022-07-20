using System;

public class Program
{
    public static void Main(string[] args)
    {
        const int listSize = 10000;
        var rnd = new Random();
        var randomList = Enumerable.Range(1, listSize).OrderBy(e => rnd.Next()).ToList();
        var listOutput = string.Join(", ", randomList);
        Console.WriteLine(listOutput);
    }
}