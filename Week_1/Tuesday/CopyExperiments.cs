// ==== Experimentation with copying value types ====

using System;

namespace copyExperiments
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name;
            name = "Jean";

            Console.WriteLine("experimentation with copying strings");

            // Question: If we create a new string...
            string name2 = name;
            Console.WriteLine("name is " + name);
            Console.WriteLine("name2 is " + name2);
            Console.WriteLine();

            // and then we change that first name...
            name = "Mt. Everest";
            Console.WriteLine("I have changed name!");

            // Does the second one change, too? (no)
            Console.WriteLine("name is " + name);
            Console.WriteLine("name2 is " + name2);
            Console.WriteLine("\n");


            int first;
            first = 46;

            Console.WriteLine("experimentation with copying ints");

            // Question: If we create a new int...
            int second = first;
            Console.WriteLine("first is " + first);
            Console.WriteLine("second is " + second);
            Console.WriteLine();

            // and then we change that first int...
            first = 16;
            Console.WriteLine("I have changed first!");

            // Does the second one change, too? (no)
            Console.WriteLine("first is " + first);
            Console.WriteLine("second is " + second);
        }
    }
}