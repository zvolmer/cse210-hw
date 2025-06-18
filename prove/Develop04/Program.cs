using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine() ?? "";
            if (choice == "1")
                new BreathingActivity().Run();
            else if (choice == "2")
                new ReflectionActivity().Run();
            else if (choice == "3")
                new ListingActivity().Run();
            else if (choice == "4")
            {
                keepRunning = false;
                continue;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }
            Console.WriteLine("\nPress Enter to return to the main menu.");
            Console.ReadLine();
        }
        Console.WriteLine("Goodbye!");
    }
}
