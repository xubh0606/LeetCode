using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _85_MaximalRectangle
    {
        public int MaximalRectangle(char[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = matrix[i][0] - '0';
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][j] < 49)
                    {
                        dp[i, j] = 0;
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1] + 1;
                    }
                }
            }
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + 1) * dp[i, j] < max)
                    {
                        continue;
                    }
                    int col = dp[i, j];
                    max = Math.Max(max, col);
                    int row = i - 1;
                    while (row >= 0 && col * (i + 1) > max)
                    {
                        col = Math.Min(col, dp[row, j]);
                        max = Math.Max(max, col * (i - row + 1));
                        row--;
                    }
                }
            }
            return max;
        }
    }
}
