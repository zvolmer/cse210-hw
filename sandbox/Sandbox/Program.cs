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


        List<string> animals = new List<string>();
        animals.Add("Cow");
        animals.Add("Horse");
        animals.Add("Pig");

        foreach (string animal in animals)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine(animals.Count);
        if (animals.Contains("Dog"))
        {
            Console.WriteLine("There is a dog.");
        }
        else
        {
            Console.WriteLine("There is no dog.");
        }

        
    }
}