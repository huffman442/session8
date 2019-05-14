using System;

namespace KataQuestions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Give me a number to convert!");
            //string numberAsString = Console.ReadLine();
            //int number = Convert.ToInt32(numberAsString);
            //string roman = MainClass.convertRoman(number);
            //string same = convertRoman(number);
            int a;
            a = 5;
            Console.WriteLine("a = " + a); // a = 5
            a = 10;
            Console.WriteLine("a = " + a); // a = 10
            a = a + 10;
            Console.WriteLine("a = " + a); // a = 20
        }

        // just use 'static' for now - it's because we're working in the console
        // I have something I can call (like above) called 'convertRoman'
        // When I call it, it will return a string
        // When I call it, I have to pass it an int.
        // This is an example of a 'function'
        static string convertRoman(int number)
        {
            return "your number in roman numerals";
        }
    }
}