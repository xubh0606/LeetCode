using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _63_UniquePathsWithObstacles
    {
        //判断是否能走，然后叠加左上的和即可
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            if (obstacleGrid[0][0] == 1)
            {
                return 0;
            }
            int[,] dp = new int[m, n];
            for (int i = 1; i < m; i++)
            {
                if (obstacleGrid[i][0] == 1)
                {
                    break;
                }
                dp[i, 0] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (obstacleGrid[0][i] == 1)
                {
                    break;
                }
                dp[0, i] = 1;
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        dp[i, j] = 0;
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }
            }
            return dp[m - 1, n - 1];
        }
    }
}
