using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _72_MinDistance
    {
        public int MinDistance(string word1, string word2)
        {
            //每次找到当前切换的最大值，如果相等则可以跳格
            int m = word1.Length;
            int n = word2.Length;
            if (m * n == 0)
            {
                return m + n;
            }
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                dp[i, 0] = i;
            }
            for (int j = 1; j <= n; j++)
            {
                dp[0, j] = j;
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    dp[i, j] = dp[i - 1, j - 1];
                    if (word1[i - 1] != word2[j - 1])
                    {
                        dp[i, j] = Math.Min(dp[i, j], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                    }
                }
            }
            return dp[m, n];
        }
    }
}
