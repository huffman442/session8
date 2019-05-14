using System;

namespace Morse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What message would you like me to translate to morse code?");
            string message = Console.ReadLine();
            string morse = "";

            for (int i = 0; i < message.Length; i++)
            {
                switch (message[i]) {
                    case 'a':
                        morse = morse + ".- ";
                        break;
                    case 'b':
                        morse = morse + "-... ";
                        break;
                    default:
                        morse = morse + message[i];
                        break;
                }
            }

            Console.WriteLine("in morse: " + morse);
            
        }
    }
}