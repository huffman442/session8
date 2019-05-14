// ==== For Loop Introduction ====
using System;

namespace CountingWhiles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            while(counter <= 10)
            {
                //Console.WriteLine("Counter is " + counter);
                //counter = counter + 1;
                // variable++ --> incrementing
                // variable-- --> decrementing
                counter++;
            }

            for(int i = 0; i <= 10; i++)
            {
                //Console.WriteLine("Counter is " + i);
            }
            //Console.WriteLine("At the end, i is " + i);

            // i-- --> use i, THEN subtract 1
            // --i --> subtract 1, THEN use i

            // a loop that counts backwards
            for(int i = 10; i != -1; i--)
            {
                //Console.WriteLine(i);
            }

            // a loop that counts by 3s and prints 7 values
            for(int i = 3; i <= 21; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}