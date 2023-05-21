using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1559_ContainsCycle
    {
        int[][] visit = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
        public bool ContainsCycle(char[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    char c = grid[i][j];
                    if (c - 'a' > -1)
                    {
                        grid[i][j] = (char)(c - 32);
                        if (FindCycle(grid, c, i, j, -1, -1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        bool FindCycle(char[][] grid, char c, int row, int col, int fatherRow, int fatherCol)
        {
            for (int i = 0; i < 4; i++)
            {
                int newRow = row + visit[i][0];
                int newCol = col + visit[i][1];
                if (newRow == fatherRow && newCol == fatherCol)
                {
                    continue;
                }
                if (newCol < 0 || newRow < 0 || newRow == grid.Length || newCol == grid[0].Length)
                {
                    continue;
                }
                char up = (char)(c - 32);
                if (grid[newRow][newCol] == up)
                {
                    return true;
                }
                if (grid[newRow][newCol] != c)
                {
                    continue;
                }
                grid[newRow][newCol] = up;
                if (FindCycle(grid, c, newRow, newCol, row, col))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
