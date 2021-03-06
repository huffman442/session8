// About to deal with shooting all ships
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
            // set up my variables
            int gridWidth = 8;
            int gridHeight = 8;

            string boat = "@";
            string emptyWater = ".";
            string boatHit = "X";

            bool keepLooping = true;
            // make a grid
            string[,] grid = new string[gridWidth, gridHeight];
            for (int row = 0; row < gridHeight; row++)
            {
                for (int column = 0; column < gridWidth; column++)
                {
                    grid[column, row] = emptyWater;
                }
            }

            // put some boats on grid
            Random rnd = new Random();

            grid[rnd.Next(0, gridWidth), rnd.Next(0, gridHeight)] = boat;
            grid[rnd.Next(0, gridWidth), rnd.Next(0, gridHeight)] = boat;
            grid[rnd.Next(0, gridWidth), rnd.Next(0, gridHeight)] = boat;

            // display grid
            for (int row = 0; row < gridHeight; row++)
            {
                for (int column = 0; column < gridWidth; column++)
                {
                    Console.Write(grid[column, row]);
                }
                Console.WriteLine();
            }
            while (keepLooping)
            {
                // ask them where they wish to shoot
                Console.WriteLine("Give me a column to shoot at!");
                int userCol = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Give me a row to shoot at!");
                int userRow = Convert.ToInt32(Console.ReadLine());
                // display results on whether they hit or missed as text
                // update grid to show results as well
                if (grid[userCol, userRow] == boat)
                {
                    Console.WriteLine("You hit my battle boat!");
                    grid[userCol, userRow] = boatHit;
                }
                else
                {
                    Console.WriteLine("You missed!");
                }
                // see if all boats hit, if so, end game
                for (int col = 0; col < gridWidth; col++)
                {
                    for (int row = 0; row < gridHeight; row++)
                    {
                        if(grid[col, row] == boat)
                        {

                        }
                    }
                }
                // display grid
                for (int row = 0; row < gridHeight; row++)
                {
                    for (int column = 0; column < gridWidth; column++)
                    {
                        Console.Write(grid[column, row]);
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}