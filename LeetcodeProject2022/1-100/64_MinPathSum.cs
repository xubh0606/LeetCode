﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _64_MinPathSum
    {
        public int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[,] dp = new int[m, n];
            dp[0, 0] = grid[0][0];
            for (int i = 1; i < m; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + grid[i][0];
            }
            for (int i = 1; i < n; i++)
            {
                dp[0, i] = dp[0, i - 1] + grid[0][i];
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                }
            }
            return dp[m - 1, n - 1];
        }
    }
}
