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
            string hiddenWater = ".";
            string hiddenShip  = "a";
            string revealedWater = "~";
            string revealedShip = "@";
            int userCol;
            int userRow;

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

            // ask where they want to shoot
            Console.WriteLine("Which column do you want to shoot in? (0 - " + (gridSize - 1) + ")");
            userCol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which row do you want to shoot in? (0 - " + (gridSize - 1) + ")");
            userRow = Convert.ToInt32(Console.ReadLine());
            
            if (grid[userCol, userRow] == hiddenShip)
            {
                Console.WriteLine("BABOOM");
                grid[userCol, userRow] = revealedShip;
            }
            else if (grid[userCol, userRow] == hiddenWater)
            {
                Console.WriteLine("SPLOOSH");
                grid[userCol, userRow] = revealedWater;
            }

            // print the grid
            for (int down = 0; down < gridSize; down++)
            {
                for (int over = 0; over < gridSize; over++)
                {
                    Console.Write(grid[over, down] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}