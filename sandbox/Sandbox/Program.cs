using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your favorite quote? ");
        string quote = Console.ReadLine();
        Console.Write("Who is the author of the quote? ");
        string author = Console.ReadLine();

        Console.WriteLine($"\"{quote}\" -{author}");
    }
}