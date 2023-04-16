using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _790_NumTilings
    {
        public int NumTilings(int n)
        {
            int MOD = 1000000007;
            int[,] dp = new int[n + 1, 2];//1: 00 2: 10 + 01 
            dp[1, 0] = 1;
            dp[1, 1] = 1;
            dp[0, 0] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i, 0] = (dp[i - 1, 0] + dp[i - 2, 0]) % MOD + (dp[i - 2, 1] * 2) % MOD;
                dp[i, 0] %= MOD;
                dp[i, 1] = (dp[i - 1, 1] + dp[i - 1, 0]) % MOD;
            }
            return dp[n, 0];
        }
    }
}
