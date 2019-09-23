using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int[][] grid = new int[20][];
        for (int grid_i = 0; grid_i < 20; grid_i++)
        {
            string[] grid_temp = Console.ReadLine().Split(' ');
            grid[grid_i] = Array.ConvertAll(grid_temp, Int32.Parse);




        }
    }
}