using System;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // print #s 1 - 100
            // if the number is a multiple of 3, print 'fizz' instead of the number.
            // if the number is a multiple of 5, print 'buzz' instead of the number.
            // if the number is a multiple of 3 AND 5, print 'fizzbuzz' instead of the number

            for(int i = 1; i <= 100; i++)
            {
                if(i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else //if (!(i % 3 == 0) && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}