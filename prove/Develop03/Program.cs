using System;

namespace ScriptureMemorizer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Scripture Memorizer!");
            Console.WriteLine();

            var reference = new Reference("John", 3, 16);
            var text = "For God so loved the world, that he gave his only begotten Son, " +
                       "that whosoever believeth in him should not perish, but have everlasting life.";
            var scripture = new Scripture(reference, text);

            while (true)
            {
                Console.Clear();
                scripture.Display();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words have been hidden. Well done!");
                    break;
                }

                Console.Write("Press ENTER to hide some words, or type \"quit\" to exit: ");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(3);
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the Scripture Memorizer. Goodbye!");
        }
    }
}