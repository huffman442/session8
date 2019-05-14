using System;

namespace ageGetter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                // read in someone's name and print it back to them
                Console.WriteLine("Hey, what's your name?");
                string userAnswer;
                userAnswer = Console.ReadLine();
                Console.WriteLine("I heard your name was " + userAnswer);
                Console.ReadLine();
            }
            {
                // also read their age and print it back.
                Console.WriteLine("What is your age?");
                //string age;
                //age = Console.ReadLine();

                //int ageAsANumber = Convert.ToInt16(age);

                int age = Convert.ToInt32(Console.ReadLine());
                string userAnswer;
                // int age = Convert.ToInt32("35")
                // int age = 35
                // the computer does one thing at a time -
                //   line 1 to line 2 to line 3
                //   first operation, second operation, third
                //   inner parentheses, next parens, outer parens
                Console.WriteLine("You are " + age + " years old!");

                // tell them how old they'll be in 5 years
                Console.WriteLine("In 5 years, you will be " + (age + 5) + " years old");
            }
        }
    }
}