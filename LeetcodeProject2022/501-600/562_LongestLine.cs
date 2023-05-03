using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _562_LongestLine
    {
        int[][] visit = new int[][] { new int[] { -1, 0 }, new int[] { 0, -1 }, new int[] { -1, -1 }, new int[] { -1, 1 } };
        public int LongestLine(int[][] mat)
        {
            int max = 0;
            int m = mat.Length;
            int n = mat[0].Length;
            int[,,] dp = new int[m, n, 4];
            if (mat[0][0] == 1)
            {
                dp[0, 0, 0] = 1;
                dp[0, 0, 1] = 1;
                dp[0, 0, 2] = 1;
                dp[0, 0, 3] = 1;
                max = 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (mat[0][i] == 1)
                {
                    dp[0, i, 0] = 1;
                    dp[0, i, 1] = dp[0, i - 1, 1] + 1;
                    dp[0, i, 2] = 1;
                    dp[0, i, 3] = 1;
                    max = Math.Max(dp[0, i, 1], max);
                }
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            int row = i + visit[k][0];
                            int col = j + visit[k][1];
                            if (row < 0 || col < 0 || col == n)
                            {
                                dp[i, j, k] = 1;
                            }
                            else
                            {
                                dp[i, j, k] = dp[row, col, k] + 1;
                                max = Math.Max(dp[i, j, k], max);
                            }
                        }
                    }
                }
            }
            return max;
        }
    }
}
