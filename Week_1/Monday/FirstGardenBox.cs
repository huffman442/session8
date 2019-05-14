// ==== First garden box - strings and math, no variables ====

using System;

namespace GardenPlanning
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // tell the user about the garden - "My garden is x feet by y feet"
            Console.WriteLine("Hello! My garden is 5 feet by 7 feet!");
            // Print out the total area and perimeter of the garden
            Console.WriteLine("The area is: " + 5 * 7);
            Console.WriteLine("The perimeter is: " + (5 + 5 + 7 + 7));
            //Console.WriteLine("perimeter: " + (4 * 2) + (10 * 2)); // 820
            // "perimeter" + 8 + 20
            // "perimeter8" + 20
            // "perimeter820"

            //Calculate and print out how many bags of soil you need. 2 bags per 3 square feet
            // 3 sq ft = 2 bags
            // 6 sq ft = 4 bags
            // (# of 3s) * 2 = # bags
            // (area / 3) * 2 = # bags

            Console.WriteLine("I'll need " + 5 * 7 / 3 * 2 + " bags of dirt at 2 bags per 3 square feet");
        }
    }
}