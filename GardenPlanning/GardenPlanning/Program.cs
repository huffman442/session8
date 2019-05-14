using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanning
{
    class GardenBox
    {
        public int length;
        public int width;

        public static int Area(int length, int width)
        {
            return length * width;
        }
        public static int Perimeter(int length, int width)
        {
            return length * 2 + width * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GardenBox myBox = new GardenBox();

            Console.WriteLine("What is the length of your garden box?");
            myBox.length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the width of your garden box?");
            myBox.width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The area of your garden box is {GardenBox.Area(myBox.length, myBox.width)} sq. ft.");
            Console.WriteLine($"The perimeter of your garden box is {GardenBox.Perimeter(myBox.length, myBox.width)} ft. ");

            Dictionary<string, double> VeggieList = new Dictionary<string, double>();
            VeggieList.Add("carrots", 16.0 / 16.0);
            VeggieList.Add("corn", 3.0 / 16.0);
            VeggieList.Add("beets", 9.0 / 16.0);

            foreach (KeyValuePair<string, double> veggie in VeggieList)
            {
                Console.WriteLine($"You could plant {veggie.Value * GardenBox.Area(myBox.length, myBox.width)} {veggie.Key}");
            }
            Console.ReadLine();
        }
    }
}
