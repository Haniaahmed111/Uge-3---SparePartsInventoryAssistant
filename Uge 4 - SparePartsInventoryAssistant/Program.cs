using System;

class Program
{
    static void Main()
    {
        string part1 = "hydraulic pump";
        string part2 = "PLC module";
        string part3 = "servo motor";

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");

        bool done = false;

        while (done == false)
        {
            Console.WriteLine("Which part do you need?");
            string input = Console.ReadLine();

            if (input == "Do you actually have any parts?" ||
                input == "Is there anything in stock at all?")
            {
                Console.WriteLine("We have 3 part(s)!");
                Console.WriteLine(part1);
                Console.WriteLine(part2);
                Console.WriteLine(part3);
            }
            else if (input == part1)
            {
                Console.WriteLine("I have got hydraulic pump here for you 😊. Bye!");
                done = true;
            }
            else if (input == part2)
            {
                Console.WriteLine("I have got PLC module here for you 😊. Bye!");
                done = true;
            }
            else if (input == part3)
            {
                Console.WriteLine("I have got servo motor here for you 😊. Bye!");
                done = true;
            }
            else
            {
                Console.WriteLine("I am afraid we don't have any " + input + " in the inventory 😔");
            }
        }
    }
}

