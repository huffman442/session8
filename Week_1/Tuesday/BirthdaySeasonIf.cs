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
            // ask for their birth month
            // tell them what season they were born in

            Console.WriteLine("What month were you born? ex 1, 2, or 3");
            string month = Console.ReadLine();

            if (month == "1" || month == "2" || month == "3" || month.Contains("feb") || month == "02")
            {
                Console.WriteLine("You were born in the winter!");
            }

            else if (month == "7" || month == "8" || month == "9")
            {
                Console.WriteLine("You were born in the summer!");
            }
            else
            {
                Console.WriteLine("I don't know that month.");
            }
            Console.ReadLine();
        }
    }
}