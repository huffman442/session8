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
            // Take in a message from a user
            // convert that message to morse code using . -
            // Give me a message
            // > hello
            // .... . .-.. .-.. ---

            Console.WriteLine("What is the message you wish to convert?");
            string message = Console.ReadLine().ToLower();
            // convert here
            message = message.Replace("a", ".- ");
            message = message.Replace("b", "-... ");


            Console.WriteLine("Your message in morse code is: " + message);
            Console.ReadLine();
        }
    }
}