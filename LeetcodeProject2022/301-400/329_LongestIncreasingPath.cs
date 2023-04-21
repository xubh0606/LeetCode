using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _329_LongestIncreasingPath
    {
        int MaxCount = 1;
        public int LongestIncreasingPath(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            int[,] dp = new int[n, m];
            int[][] visit = new int[][] 
            { 
                new int[] { 0, 1 }, 
                new int[] { 1, 0 }, 
                new int[] { 0, -1 }, 
                new int[] { -1, 0 } 
            };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[i, j] = -1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (dp[i, j] == -1)
                    {
                        dfs(dp, matrix, n, m, i, j, visit);
                    }
                }
            }
            return MaxCount;
        }
        int dfs(int[,] dp, int[][] matrix, int n, int m, int row, int col, int[][] visit)
        {
            if (dp[row, col] != -1)
            {
                return dp[row, col];
            }
            dp[row, col] = 1;
            int cur = matrix[row][col];
            for (int i = 0; i < 4; i++)
            {
                if (row + visit[i][0] >= 0 
                    && row + visit[i][0] < n 
                    && col + visit[i][1] >= 0
                    && col + visit[i][1] < m 
                    && cur < matrix[row + visit[i][0]][col + visit[i][1]])
                {
                    dp[row, col] = Math.Max(
                        dp[row, col],
                        1 + dfs(dp, matrix, n, m, row + visit[i][0],
                        col + visit[i][1], visit
                        ));
                }
            }
            MaxCount = Math.Max(dp[row, col], MaxCount);
            return dp[row, col];
        }
    }
}
