// === Message system 1: framework in place ===
using System;

namespace MessagingSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Reflections:
            // * loops are understandable on their own. When you start putting things inside things, yowch.
            // * take one small thing at a time. Make the first thing work first. Isolate.

            // John's tips:
            // * Work on what you know how to do first.
            // * Use stubs to get the framework in place
            // * separate the code into sections where you can only focus on that section.

            // Show a menu that lets a user choose
            // * a. to save a message
            // * b. to retrieve a message by id
            // * c. to exit

            // When saving a message, the program should tell the user the id it used to save.
            // When retrieving a message, ask the user which one they want to see.
            // After they complete either action, show the menu again.

            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("a: save a message");
                Console.WriteLine("b: retrieve a message");
                Console.WriteLine("c: quit\n");

                string choice = Console.ReadLine().ToLower();

                if (choice == "a")
                {
                    Console.WriteLine("You chose to save a message.");
                }
                else if (choice == "b")
                {
                    Console.WriteLine("You chose to retrieve a message.");
                }
                else if (choice == "c")
                {
                    Console.WriteLine("You chose to quit.");
                }
                else
                {
                    Console.WriteLine("That one's not an option, try again?");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}