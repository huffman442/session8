using System;

namespace gardenBoxWithVariables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's the width of your garden plot (in feet)?");
            string widthAsString;
            widthAsString = Console.ReadLine();

            Console.WriteLine("and length?");
            string lengthAsString;
            lengthAsString = Console.ReadLine();

            //print the area
            int width  = Convert.ToInt32(widthAsString);
            int length = Convert.ToInt32(lengthAsString);
            int area = length * width;
            Console.WriteLine("The area of your garden plot is " + area + " square feet");

            //print the perimeter
            Console.WriteLine("And the perimeter is " + (length * 2 + width * 2));

            // corn is 3 stalks per 4x4 area - how much can they plant?
            // area / 16 / 3
            double corn = 16.0 / 3.0;
            Console.WriteLine("In that space, you can plant ");
            Console.WriteLine("  * " + area / corn + " corn plants");
            Console.WriteLine("  * " + area + " carrots");
            Console.WriteLine("  * or " + area * 9 / 16.0 + " beets");
        }
    }
}