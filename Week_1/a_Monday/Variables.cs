using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // First let us declare some variables

            int a; // we now have an integer named a, with no value
            a = 2; // a now has the value 2

            //Console.WriteLine("a = " + a);



            // We can also do this all in one line
            int b = 2;
            // same as:
            // int b;
            // b = 2;

            //Console.WriteLine("b = " + b);

            // You don't have to have single values to the right of the assignment operator =

            b = 2 * 2 + 18; // 22? 
            //Console.WriteLine("b = " + b);

            // This is also true when declaring a variable

            int c = 99 + (4 / 2 + 5);

            //Console.WriteLine("c = " + c);


            // You can have multiple assignment operators in a single line, although you need to make sure it isn't too hard to read

            a = b = c = 10;

            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine("c = " + c);

            //You can also declare multiple variables on the same line
            //Oops! It will only assign a value to the last variable declared
            int d, e, f = 5;
            
            //Console.WriteLine("f = " + f);


            // Strings work the same way

            string x = "This is a string";
            //Console.WriteLine(x);

            // But now what happens if you do this?

            string someString = "string!";
            int number = 4;
            //someString = number.ToString(); // weird, right? + has an implicit conversion but = doesn't.
            // .ToString() is an explicit conversion
            someString = someString + number; // this works just fine, though
            // as we get further, we'll look into functions, then function overloading and then operators and this will make more sense
            // but basically, every operator (+, *, =, etc) all have their own list of ways it can interact and conversions, they don't all have to be the same

            someString = "5";
            //number = someString;
            // What about a force conversion?
            someString = number.ToString();
            someString = "23";
             number = Convert.ToInt16(someString); // what happens if someString isn't a nice number, though?
                                                   //Console.WriteLine(number); // won't compile? //23?

            //someString = "not a number";
            //number = Convert.ToInt16(someString); // oh. an exception

            // Console.ReadLine();


            // What about doing something like this?

            Console.WriteLine("please enter a number");
            string userAnswer;
            userAnswer = Console.ReadLine();

            Console.WriteLine("Here is what you typed: " + userAnswer);
            number = Convert.ToInt16(userAnswer);
            Console.ReadLine();
        }
    }
}