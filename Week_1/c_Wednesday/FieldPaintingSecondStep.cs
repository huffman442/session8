using System;

namespace FieldPainting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Help someone who's trying to paint a circle buy the right amount of paint.
            // With real world problems - You'll write a small version, then change it to add a little more, then do that again and again.

            // Explain what the program does
            Console.WriteLine("I can help you figure out how much paint to buy to cover a circle on your field. Different colors have different coverages, so the color impacts how much you need.");
            Console.WriteLine();

            // Ask for the size of the circle
            Console.WriteLine("What is the radius of the circle in feet? (e.g. 25.5)");
            string radiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsString);

            // Find the area. The formula is pi * r^2
            double area = Math.PI * radius * radius;

            Console.WriteLine("Your circle has an area of " + Math.Round(area, 2) + " square feet");

            // Before we can find how many buckets, we need to know what color.
            Console.WriteLine("What color would you like to paint the field? Options: Red, Blue, Yellow, Green");
            string color = Console.ReadLine().ToUpper();

            // Figure out how much space a bucket covers based on its color
            int lowestPossibleCoverage = 70;
            int coverage = lowestPossibleCoverage;
            if(color == "RED")
            {
                coverage = 100;
            }
            if(color == "BLUE")
            {
                coverage = 120;
            }
            if(color == "GREEN")
            {
                coverage = 90;
            }
            if(color == "YELLOW")
            {
                coverage = 70;
            }

            // Find how many buckets. Divide area by the amount of space a bucket of paint covers.
            double buckets = area / coverage;

            Console.WriteLine("You need " + Math.Round(buckets, 2) + " buckets of " + color.ToLower() + " paint to cover that circle, so you should buy " + Math.Ceiling(buckets) + " buckets.");
        }
    }
}