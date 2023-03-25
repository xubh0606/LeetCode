using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _200_NumIslands
    {
        int[][] m_visit = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != '0')
                    {
                        count++;
                        dfs(i, j, grid);
                    }
                }
            }
            return count;
        }
        void dfs(int row, int col, char[][] grid)
        {
            grid[row][col] = '0';
            for (int i = 0; i < 4; i++)
            {
                int new_row = row + m_visit[i][0];
                int new_col = col + m_visit[i][1];
                if (new_col < 0 || new_col == grid[0].Length || new_row < 0 || new_row == grid.Length)
                {
                    continue;
                }
                if (grid[new_row][new_col] != '0')
                {
                    dfs(new_row, new_col, grid);
                }
            }
        }
    }
}
