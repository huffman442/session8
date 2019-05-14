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
            // make a grid
            string[,] grid = new string[gridHeight, gridWidth];
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    grid[i, j] = "W";
                }
            }
            // put some boats on grid
            // display grid
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
            // ask them where they wish to shoot
            // display results on whether they hit or missed as text
            // update grid to show results as well
            // see if all boats hit, if so, end game
            // display grid

            Console.ReadLine();
        }
    }
}