using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFinder
{
    class Person
    {
        public string name;
        public int age;
        public DateTime birthday;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person(); // Creates a new 'Person'

            Console.WriteLine("What is your name?"); // Takes in user's name
            user.name = Console.ReadLine();

            Console.WriteLine("What is your birthday in MM/DD/YYYY"); //  Takes in user's age
            user.birthday = Convert.ToDateTime(Console.ReadLine());

            user.age = DateTime.Now.Year - user.birthday.Year; // Calculates users age
            if(DateTime.Now.DayOfYear < user.birthday.DayOfYear) //Figures out if they've had a birthday this year or not
            {
                user.age -= 1;
            }

            Console.WriteLine($"Hello {user.name}! You are {user.age} years old!");

            //switch (user.birthday.Month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("You were born in winter!");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("You were born in spring!");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("You were born in Summer!");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("You were born in Fall!");
            //        break;
            //}
            Console.ReadLine();

        }

    }
}
