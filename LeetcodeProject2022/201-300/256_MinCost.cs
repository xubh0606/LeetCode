using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _256_MinCost
    {
        public int MinCost(int[][] costs)
        {
            int[,] dp = new int[costs.Length, 3];
            dp[0, 0] = costs[0][0];
            dp[0, 1] = costs[0][1];
            dp[0, 2] = costs[0][2];
            for (int i = 1; i < costs.Length; i++)
            {
                dp[i, 0] = costs[i][0] + Math.Min(dp[i - 1, 1], dp[i - 1, 2]);
                dp[i, 1] = costs[i][1] + Math.Min(dp[i - 1, 0], dp[i - 1, 2]);
                dp[i, 2] = costs[i][2] + Math.Min(dp[i - 1, 1], dp[i - 1, 0]);
            }
            return Math.Min(dp[costs.Length - 1, 0], Math.Min(dp[costs.Length - 1, 1], dp[costs.Length - 1, 2]));
        }
    }
}
