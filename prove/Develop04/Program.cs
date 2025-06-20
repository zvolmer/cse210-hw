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
            {
                new BreathingActivity().Run();
                Console.WriteLine("\nPress Enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                Console.WriteLine("\nPress Enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                Console.WriteLine("\nPress Enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
