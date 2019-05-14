// basic math
using System;


namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {

            // Here are a few simple math equations
           
            Console.WriteLine(2 + 3); //5
            Console.WriteLine(2 * 3); //6

            Console.WriteLine(2 + 2 * 8); // * first then the + //18?
            Console.WriteLine((2 + 2) * 8); // () first then the * //32?

            Console.ReadLine();

            // Garden Beds
            // 8' x 4'
            // Area and Perimeter
            // Area = length * width
            // Perimeter = length * 2 + width * 2

            Console.WriteLine(3 / 2 * 4.0); // what will happen here? //6? --> 4
            // 3/2 --> 1.5 <-- decimal division
            // 3/2 --> 1  <-- integer division
            // integer
            // double
            // "implicit conversion"
            // computer looks at one thing at a time

            /*
             * Here are some comments!
             * The computer will see none of this!
             * My editor makes those stars automatically!
             * Console.WriteLine("hello world");
             */

            Console.WriteLine(3.0 / (2 * 4)); // and here? // 3/8? - .375?  --> 0
            // 3 / (2 * 4) --> 0
            // 3.0 / (2 * 4) --> 0.375
            // make a hypothesis about what will happen when you run
            // run a lot
            
            // Console.WriteLine() --> puts text into the console
            // Console.ReadLine() --> pulls text from the console

            // ===== Math with Constants =====

            
            // area of a circle with radius 10
            // formula is pi * r^2
            Console.WriteLine("area of a circle with radius 10 is: " + (3.14 * 10 * 10));
            // C# provides some constants for you from Math, like Pi
            Console.WriteLine("pi is: " + Math.PI);
            // C#'s Math library provides some cool functions for you, like powers.
            Console.WriteLine("another way to find the area: " + (Math.PI * Math.Pow(10, 2)));
            Console.ReadLine();

        }
    }
}