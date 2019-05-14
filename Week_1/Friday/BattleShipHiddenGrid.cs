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
            string miss = "O";

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
                    if(grid[column, row] == boat)
                    {
                        Console.Write(emptyWater);
                    }
                    else if(grid[column, row] == emptyWater)
                    {
                        Console.Write(emptyWater);
                    }
                    else if (grid[column, row] == boatHit)
                    {
                        Console.Write(boatHit);
                    }
                    else if (grid[column, row] == miss)
                    {
                        Console.Write(miss);
                    }
                    // Console.Write(grid[column, row]);
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
                bool gameOver = true;
                for (int col = 0; col < gridWidth; col++)
                {
                    for (int row = 0; row < gridHeight; row++)
                    {
                        if(grid[col, row] == boat)
                        {
                            gameOver = false;
                        }
                    }
                }
                if(gameOver)
                {
                    keepLooping = false;
                    Console.WriteLine("You sunk all of my battleboats!");
                }
                // display grid
                for (int row = 0; row < gridHeight; row++)
                {
                    for (int column = 0; column < gridWidth; column++)
                    {
                        if (grid[column, row] == boat)
                        {
                            Console.Write(emptyWater);
                        }
                        else if (grid[column, row] == emptyWater)
                        {
                            Console.Write(emptyWater);
                        }
                        else if (grid[column, row] == boatHit)
                        {
                            Console.Write(boatHit);
                        }
                        else if (grid[column, row] == miss)
                        {
                            Console.Write(miss);
                        }
                        // Console.Write(grid[column, row]);
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}