// ==== Jean's array examples - enter 10 names and print them back out ====

using System;

namespace arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name;
            name = "John";
            Console.WriteLine("name is: " + name);

            // in C#, it's usual practice to name different things with different cases:
            // variablesUseCamelCase
            // LibrariesOrClassesUseTitleCase

            int numberOfNames = 10;
            string[] names;
            names = new string[numberOfNames];

            //Console.WriteLine("What is name number 1?");
            //names[0] = Console.ReadLine();
            //Console.WriteLine("What is name number 2?");
            //names[1] = Console.ReadLine();
            //Console.WriteLine("What is name number 3?");
            //names[2] = Console.ReadLine();

            //Console.WriteLine("What is the LAST NAME?");
            ////names[10] = Console.ReadLine(); // index out of range exception error!
            //// 9 is the last position.
            //names[9] = Console.ReadLine();
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Give me name number " + (i + 1));
                names[i] = Console.ReadLine();
            }

            // printing out names
            Console.WriteLine("first name: " + names[0]);

            //printing out all the names
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("name number " + (i + 1) + " is " + names[i]);
            }

            Console.ReadLine();
        }
    }
}