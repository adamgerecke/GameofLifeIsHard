using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] grid = { { "*", "*", "*", "*", "*" }, { "*", "*", "*", "*", "*" }, { "*", "-", "-", "-", "*" }, { "*", "*", "*", "*", "*" }, { "*", "*", "*", "*", "*" } };

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j<5; j++)
                {
                    Console.Write(grid[i,j]);
                }
                Console.WriteLine();
            }
            
        }
         
    }
}
