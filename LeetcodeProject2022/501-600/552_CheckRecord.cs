using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _552_CheckRecord
    {
        int m_MOD = 1000000007;
        public int CheckRecord(int n)
        {
            long[,] dp = new long[2, 3];
            dp[0, 0] = 1;
            for (int i = 0; i < n; i++)
            {
                long[,] new_dp = new long[2, 3];
                new_dp[0, 0] = dp[0, 1];
                new_dp[0, 0] %= m_MOD;
                new_dp[0, 0] += dp[0, 2];
                new_dp[0, 0] %= m_MOD;
                new_dp[0, 0] += dp[0, 0];
                new_dp[0, 0] %= m_MOD;
                new_dp[1, 0] = dp[0, 2];
                new_dp[1, 0] %= m_MOD;
                new_dp[1, 0] += dp[0, 1];
                new_dp[1, 0] %= m_MOD;
                new_dp[1, 0] += dp[1, 1];
                new_dp[1, 0] %= m_MOD;
                new_dp[1, 0] += dp[1, 0];
                new_dp[1, 0] %= m_MOD;
                new_dp[1, 0] += dp[1, 2];
                new_dp[1, 0] %= m_MOD;
                new_dp[1, 0] += dp[0, 0];
                new_dp[1, 0] %= m_MOD;
                new_dp[0, 1] = dp[0, 0];
                new_dp[0, 1] %= m_MOD;
                new_dp[0, 2] = dp[0, 1];
                new_dp[0, 2] %= m_MOD;
                new_dp[1, 1] = dp[1, 0];
                new_dp[1, 1] %= m_MOD;
                new_dp[1, 2] = dp[1, 1];
                new_dp[1, 2] %= m_MOD;
                dp = new_dp;
            }
            return (int)(((dp[0, 0] + dp[1, 0]) % m_MOD + (dp[0, 1] + dp[0, 2]) % m_MOD) % m_MOD + (dp[1, 1] + dp[1, 2]) % m_MOD) % m_MOD;
        }
    }
}
