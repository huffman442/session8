// Jean BattleShip 1: place boats randomly and display the grid.

using System;

namespace BattleshipButForReal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int gridSize = 10;
            int numberOfRandomShips = 4;
            string[,] grid = new string[gridSize,gridSize];
            string hiddenWater = "~";
            string hiddenShip  = "@";

            // fill in the grid
            for (int down = 0; down < gridSize; down++)
            {
                for (int over = 0; over < gridSize; over++)
                {
                    grid[over, down] = hiddenWater;
                }
            }

            // place some ships randomly
            Random random = new Random();
            int r1 = 0;
            int r2 = 0;
            for (int i = 0; i < numberOfRandomShips; i++)
            {
                r1 = random.Next(0, gridSize);
                r2 = random.Next(0, gridSize);
                grid[r1, r2] = hiddenShip;
            }

            // print the grid
            for (int down = 0; down < gridSize; down++)
            {
                for(int over = 0; over < gridSize; over++)
                {
                    Console.Write(grid[over, down] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}