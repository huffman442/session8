using System;

namespace stringsAreArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "Jean";
            Console.WriteLine("Full string is: " + s);
            Console.WriteLine("s[1] is: " + s[1]);
            Console.WriteLine("s.Length is: " + s.Length);
            //s[0] = "q";

            Console.WriteLine("\nUsing a for loop to print out each character:");

            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}