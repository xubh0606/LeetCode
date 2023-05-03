using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1594_MaxProductPath
    {
        public int MaxProductPath(int[][] grid)
        {
            //比较策略：正数比较大的，负数比较小的，0作为正数参加讨论(取大)
            int m = grid.Length;
            int n = grid[0].Length;
            long[,] negative = new long[m, n];
            long[,] notNegative = new long[m, n];
            if(grid[0][0] == 0)
            {
                return 0;
            }
            else if(grid[0][0] < 0)
            {
                negative[0, 0] = grid[0][0];
            }
            else
            {
                notNegative[0, 0] = grid[0][0];
            }
            for (int i = 1; i < n; i++)
            {
                if (grid[0][i] < 0)
                {
                    negative[0, i] = notNegative[0, i-1]*grid[0][i];
                    notNegative[0, i] = negative[0, i - 1] * grid[0][i];
                }
                else
                {
                    notNegative[0, i] = notNegative[0, i - 1] * grid[0][i];
                    negative[0, i] = negative[0, i - 1] * grid[0][i];
                }
            }
            for (int i = 1; i < m; i++)
            {
                if (grid[i][0] < 0)
                {
                    negative[i, 0] = notNegative[i - 1, 0] * grid[i][0];
                    notNegative[i, 0] = negative[i - 1, 0] * grid[i][0];
                }
                else
                {
                    notNegative[i, 0] = notNegative[i - 1, 0] * grid[i][0];
                    negative[i, 0] = negative[i - 1, 0] * grid[i][0];
                }
                for (int j = 1; j < n; j++)
                {
                    int cur = grid[i][j];
                    if (cur < 0)
                    {
                        negative[i, j] = Math.Min(notNegative[i - 1, j] * cur, notNegative[i, j - 1] * cur);
                        notNegative[i, j] = Math.Max(negative[i - 1, j] * cur, negative[i, j - 1] * cur);
                    }
                    else
                    {
                        notNegative[i, j] = Math.Max(notNegative[i - 1, j] * cur, notNegative[i, j - 1] * cur);
                        negative[i, j] = Math.Min(negative[i - 1, j] * cur, negative[i, j - 1] * cur);
                    }
                }
            }
            if (notNegative[m - 1, n - 1] == 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (grid[i][j] == 0)
                        {
                            return 0;
                        }
                    }
                }
                return -1;
            }
            return (int)(notNegative[m - 1, n - 1] % 1000000007);
        }
    }
}
