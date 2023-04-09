using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _221_MaximalSquare
    {
        public int MaximalSquare(char[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[,] dp = new int[m, n];
            int maxHight = 0;
            dp[0, 0] = matrix[0][0] - '0';
            if (dp[0, 0] > 0)
            {
                maxHight = 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (matrix[0][i] == '1')
                {
                    dp[0, i] = 1;
                    maxHight = 1;
                }
                else
                {
                    dp[0, i] = 0;
                }
            }
            for (int i = 1; i < m; i++)
            {
                dp[i, 0] = matrix[i][0] - '0';
                if (dp[i, 0] > 0 && maxHight == 0)
                {
                    maxHight = 1;
                }
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                        if (dp[i, j] > maxHight)
                        {
                            maxHight = dp[i, j];
                        }
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }
            return maxHight * maxHight;
        }
    }
}
