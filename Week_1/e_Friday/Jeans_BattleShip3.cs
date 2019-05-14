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
            int hiddenShips = numberOfRandomShips;

            // fill in the grid
            for (int row = 0; row < gridSize; row++)
            {
                for (int column = 0; column < gridSize; column++)
                {
                    grid[column, row] = hiddenWater;
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

            while (hiddenShips > 0)
            {
                // print the grid
                for (int row = 0; row < gridSize; row++)
                {
                    for(int column = 0; column < gridSize; column++)
                    {
                        Console.Write(grid[column, row] + " ");
                    }
                    Console.WriteLine();
                }

                // how many hidden ships are left?
                hiddenShips = 0;
                for (int row = 0; row < gridSize; row++)
                {
                    for (int column = 0; column < gridSize; column++)
                    {
                        if (grid[column, row] == hiddenShip)
                        {
                            hiddenShips++;
                        }
                    }
                }
                if (hiddenShips > 0)
                {
                    Console.WriteLine("You still have to find " + hiddenShips + " of my ships!");

                    // ask where they want to shoot
                    Console.WriteLine("Which column do you want to shoot in? (0 - " + (gridSize - 1) + ")");
                    userCol = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Which row do you want to shoot in? (0 - " + (gridSize - 1) + ")");
                    userRow = Convert.ToInt32(Console.ReadLine());

                    // take the shot - tell them what happened and update the grid
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
                }
            }
            Console.WriteLine("You got my last ship!!! Foiled again! Blub blub blub...");
        }
    }
}