using System;
using System.Collections.Generic;
using System.Threading;


    public class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private Random _rand = new Random();

        public ReflectionActivity()
            : base(
                "Reflection Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience."
            )
        { }

        protected override void PerformActivity()
        {
            string prompt = _prompts[_rand.Next(_prompts.Count)];
            Console.WriteLine("\n--- Prompt ---");
            Console.WriteLine(prompt);
            Console.WriteLine("\nWhen you have something in mind, press Enter.");
            Console.ReadLine();

            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                string question = _questions[_rand.Next(_questions.Count)];
                Console.WriteLine("\n" + question);
                Thread.Sleep(5000); 
            }
        }
    }

