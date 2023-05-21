using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _96_NumTrees
    {
        public int NumTrees(int n)
        {
            long[] dp = new long[n + 1];
            dp[1] = 1;
            for (int i = 1; i < n; i++)
            {
                dp[i + 1] = dp[i] * (4 * i + 2) / (i + 2);
            }
            return (int)dp[n];
        }
    }
}
