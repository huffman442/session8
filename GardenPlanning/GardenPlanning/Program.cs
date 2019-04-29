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
        public int area;
    }
    class Program
    {
        static void Main(string[] args)
        {
            GardenBox myBox = new GardenBox();
            myBox.length = 5;
            myBox.width = 7;
            myBox.area = myBox.length * myBox.width;
            Console.WriteLine(myBox.area);
            Console.ReadLine();
        }
    }
}
