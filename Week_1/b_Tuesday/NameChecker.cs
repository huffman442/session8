using System;

namespace NameChecker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Ask a person for their name
            //   Ask = Console.WriteLine + Console.ReadLine
            //   name is something I want to save in a variable, because I want to use it again later.
            //     I'll call it 'userName'.
            //     It's of type 'string'
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            // Tell them if they have the letter 'a' in their name
            //  keywords: Tell (Console.WriteLine), if (write a conditional), name (that variable I saved before)
            // What if we wanted to check if 'john' is in there? with any capitalization?
            // John, JOHN, john, JoHn, JoHN, JOhn, JOHn, JOhN...
            if (userName.Contains("a") || userName.Contains("A"))
            {
                Console.WriteLine("Your name has an a!");
            }
            // with this 'if', userName still contains whatever the user typed in - we don't change its capitalization.
            // BUT we're testing against a lowercase version.
            if (userName.ToLower().Contains("john"))
            {
                Console.WriteLine("Your name contains John!");
            }


            // Tell them if their name is longer than 10 characters
            //   keywords: tell (WriteLine), if (conditional) name (that variable we saved before)
            if (userName.Length > 10)
            {
                Console.WriteLine("Your name is longer than 10 characters. That's pretty long!");
            }

            Console.WriteLine("Thanks for using this program, " + userName);
            Console.ReadLine();
            
        }
    }
}