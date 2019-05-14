// === Message system 2: works with 1 message ===
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

            // * Don't build the whole skyscraper on one side first - build a floor on A, then a floor on B.
            // * YAGNI - You Ain't Gonna Need It.
            // * Data that lives for multiple loops needs to be created outside the loop.
            //   * This is an example of 'state' - the values of all of the variables of a program at any given moment.

            // Show a menu that lets a user choose
            // * a. to save a message
            // * b. to retrieve a message by id
            // * c. to exit

            // When saving a message, the program should tell the user the id it used to save.
            // When retrieving a message, ask the user which one they want to see.
            // After they complete either action, show the menu again.

            string message = "You must save a message before attempting to retrieve.";

            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("a: save a message");
                Console.WriteLine("b: retrieve a message");
                Console.WriteLine("c: quit\n");

                string choice = Console.ReadLine().ToLower();

                if (choice == "a")
                {
                    Console.WriteLine("\nWhat message would you like to save?");
                    message = Console.ReadLine();
                    Console.WriteLine("I got your message: " + message);
                }
                else if (choice == "b")
                {
                    Console.WriteLine("Here's your message: " + message);
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