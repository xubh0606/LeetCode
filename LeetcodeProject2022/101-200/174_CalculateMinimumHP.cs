using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _174_CalculateMinimumHP
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int m = dungeon.Length;
            int n = dungeon[0].Length;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = m; i >= 0; i--)
            {
                for (int j = n; j >= 0; j--)
                {
                    dp[i, j] = int.MaxValue;
                }
            }
            dp[m, n - 1] = 1;
            dp[m - 1, n] = 1;
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int min_curHealth = Math.Min(dp[i + 1, j], dp[i, j + 1]) - dungeon[i][j];
                    dp[i, j] = Math.Max(1, min_curHealth);
                }
            }
            return dp[0, 0];
        }
    }
}
