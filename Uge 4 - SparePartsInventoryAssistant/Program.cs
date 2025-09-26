using System;
using System.Linq;

class Program
{
    static void Main()
    {

        string[] parts = { "hydraulic pump", "PLC module", "servo motor" };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");

        bool running = true;
        while (running)
        {
            Console.Write("Which part do you need? ");
            string input = Console.ReadLine()?.Trim() ?? "";


            if (input.Length == 0)
            {
                Console.WriteLine("You must type something.");
                continue;
            }


            if (string.Equals(input, "Do you actually have any parts?", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(input, "Is there anything in stock at all?", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"We have {parts.Length} part(s)!");
                foreach (var p in parts)
                {
                    Console.WriteLine(p);
                }

                continue;
            }


            if (parts.Contains(input))
            {
                Console.WriteLine($"I've got {input} here for you 😊");
                running = false; 
            }
            else
            {
                Console.WriteLine($"I am afraid we don’t have any {input} in the inventory 😔");
            }
        }

        Console.WriteLine("(program exits)");
    }
}



