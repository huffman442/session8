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

            switch (month)
            {
                case "6":
                case "7":
                case "8":
                case "june":
                case "july":
                case "what?":
                    Console.WriteLine("You were born in the summer!");
                    break;
                case "12":
                case "december":
                case "1":
                case "2":
                    Console.WriteLine("It was probably cold when you were born.");
                    break;
            }


            Console.ReadLine();
        }
    }
}