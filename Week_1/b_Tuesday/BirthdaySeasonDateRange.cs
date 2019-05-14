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

            Console.WriteLine("What day of the year (1-365) were you born on?");
            int day = Convert.ToInt32(Console.ReadLine());

            if ((day >= 80) && (day <= 172))
            {
                Console.WriteLine("You were born in the spring!");
            }
            Console.ReadLine();
        }
    }
}