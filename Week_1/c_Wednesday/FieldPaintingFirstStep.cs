using System;

namespace FieldPainting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Help someone who's trying to paint a circle buy the right amount of paint.
            // With real world problems - You'll write a small version, then change it to add a little more, then do that again and again.

            // Ask for the size of the circle
            Console.WriteLine("What is the radius of the circle in feet? (e.g. 25.5)");
            string radiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsString);

            // Find the area. The formula is pi * r^2
            double area = Math.PI * radius * radius;

            Console.WriteLine("Your circle has an area of " + Math.Round(area, 2) + " square feet");

            // Find how many buckets. Divide area by 100
            double buckets = area / 100;

            Console.WriteLine("You need " + Math.Round(buckets, 2) + " buckets of paint to cover that circle, so you should buy " + Math.Ceiling(buckets) + " buckets.");
        }
    }
}