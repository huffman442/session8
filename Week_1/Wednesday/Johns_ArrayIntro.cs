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
            string name;
            name = "John";
            Console.WriteLine("Your name is: " + name);


            string[] names;
            names = new string[10];
            
            Console.WriteLine("Give me the first name!");
            names[0] = Console.ReadLine();

            Console.WriteLine("Give me the second name:");
            names[1] = Console.ReadLine();

            Console.WriteLine("Give me the last name!");
            names[9] = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            //Console.WriteLine(names[0]);


            Console.ReadLine();
        }
    }
}