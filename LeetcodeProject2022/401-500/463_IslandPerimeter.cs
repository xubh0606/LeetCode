using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _463_IslandPerimeter
    {
        public int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            int left = 0;
            int h = grid.Length;
            int l = grid[0].Length;
            for (int row = 0; row < h; row++)
            {
                if (left != 0)
                {
                    perimeter++;
                    left = 0;
                }
                for (int col = 0; col < l; col++)
                {
                    int isIsland = grid[row][col];
                    if (isIsland == 1)
                    {
                        if (row == 0)
                        {
                            perimeter++;
                        }
                        else
                        {
                            if (grid[row - 1][col] == 0)
                            {
                                perimeter++;
                            }
                        }
                        if (left == 0)
                        {
                            perimeter++;
                        }
                        left = 1;
                    }
                    else
                    {
                        if (row != 0 && grid[row - 1][col] == 1)
                        {
                            perimeter++;
                        }
                        if (left == 1)
                        {
                            perimeter++;
                        }
                        left = 0;
                    }
                }
            }
            for (int i = 0; i < l; i++)
            {
                if (grid[h - 1][i] == 1)
                {
                    perimeter++;
                }
            }
            if (grid[h - 1][l - 1] == 1)
            {
                return perimeter + 1;
            }
            return perimeter;
        }
    }
}
