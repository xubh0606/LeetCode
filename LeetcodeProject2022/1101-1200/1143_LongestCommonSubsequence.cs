using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1143_LongestCommonSubsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int m = text1.Length;
            int n = text2.Length;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i < m; i++)
            {
                char c1 = text1[i];
                for (int j = 0; j < n; j++)
                {
                    char c2 = text2[j];
                    if (c1 == c2)
                    {
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                    }
                    else
                    {
                        dp[i + 1, j + 1] = Math.Max(dp[i, j + 1], dp[i + 1, j]);
                    }
                }
            }
            return dp[m, n];
        }
    }
}
