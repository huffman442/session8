using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are helping with a local soccer league
            // They need to be able to paint their fields
            // to mark the center circle. Different leagues
            // have different sized circles, however. Make
            // a program that will ask for the size of the
            // circle and then tell them how much paint they
            // need to cover the center circle. The paint
            // they use covers about 100 sq ft per bucket.
            // Make sure they have enough paint, it's ok
            // if there is some extra left in the last
            // bucket

            // Show the output like this:
            // It will take 8 buckets to paint the 15' radius circle

            // Bonus: Different colors cover better than
            // others. Let the user pick the color and show
            // the result. The colors are as follows:
            // Red = 100 sq ft/bucket
            // Blue = 120 sq ft/bucket
            // Green = 90 sq ft/bucket
            // Yellow = 70 sq ft/bucket

            // Extra Bonus: The colors also cost different
            // amounts. Tell the user how much it will cost
            // to paint their field.
            // Red = 25$ / bucket
            // Blue = 28$ / bucket
            // Green = 33$ / bucket
            // Yellow = 22$ / bucket


            Console.WriteLine("WHat is the radius of your circle?");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            double area = Math.PI * radius * radius;

            Console.WriteLine("The area you are painting is " + area + " feet");

            Console.WriteLine("What color are you painting the field? Red, Blue, Yellow, Green?");
            string color = Console.ReadLine().ToUpper();


            int coverage = 70; // This is the lowest possible coverage

            if(color == "RED")
            {
                coverage = 100;
            }
            if(color == "BLUE")
            {
                coverage = 120;
            }
            if (color == "GREEN")
            {
                coverage = 90;
            }
            if (color == "YELLOW")
            {
                coverage = 70;
            }

            double buckets = area / coverage;
            buckets = Math.Ceiling(buckets);
            Console.WriteLine("You will need " + buckets + " buckets to cover the field.");

            Console.ReadLine();
        }
    }
}