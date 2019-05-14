using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
    static void Main(string[] args)
    {
        //String Input;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //int numb = 0;
        string[,] grid = new string[10, 11];
        string[] update = new string[1]; // UPDATE MESSAGE WHEN HIT OR MISS
        //int Ships = 0;
        //Grid Set UP
        for (int a = 0; a < 8; a++) // X
        {
            for (int i = 0; i < 8; i++) // Y
            {
                //grid Default Values
                grid[a, i] = "~";
                //X axis Grid Numbers
                {
                grid[7, 9] = "8";
                grid[6, 9] = "7";
                grid[5, 9] = "6";
                grid[4, 9] = "5";
                grid[3, 9] = "4";
                grid[2, 9] = "3";
                grid[1, 9] = "2";
                grid[0, 9] = "1";
                }
                //Y axis Grid Numbers
                {
                grid[9, 0] = "1";
                grid[9, 1] = "2";
                grid[9, 2] = "3";
                grid[9, 3] = "4";
                grid[9, 4] = "5";
                grid[9, 5] = "6";
                grid[9, 6] = "7";
                grid[9, 7] = "8";
                grid[i, 8] = "|";
                }
            }
        }
        //DRAW GRID
        while (true)
        {
        for (int a = 0; a < 10; a++)
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(grid[i, a] + "-");
            }
        }

        //int [] answers = new int[64];
        int x = 0;
        int y = 0;

            // grid[x,y].Replace("X", "$");

            //USER INPUT
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(update[0]);
            Console.WriteLine();
            Console.WriteLine("Select Row (0,0) [ Horizontal __ ]");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Select Collumn(" + x + ",0) [ Verticle | ]");
            y = Convert.ToInt32(Console.ReadLine());

        
            
            if (x <= 8 || y <= 8)
            {
            
                if (x == 5 && x <= 8 || y == 5 && y <= 8)
                {
                    update[0] = "You Hit a Ship!";
                    grid[--x, --y] = "#";
                }
                else
                {
                    // = answers[numb++];
                    update[0] = "You Missed The Ship!";
                    grid[--x, --y] = "O";
                }
            }
            
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid value , Please Choose 1-8");
                Console.WriteLine("Press a Key To Continue");
                Console.ReadLine();
            }
            // x--> grid [x,y]
            // use coordinates of X & Y to assign block number of grid array to change
            Console.Clear();
            


        }
    }
}