using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _526_CountArrangement
    {
        public int CountArrangement(int n)
        {
            int[] dp = new int[1 << n];
            dp[0] = 1;
            for (int i = 1; i < (1 << n); i++)
            {
                int numOf = getOne(i);
                for (int j = 0; j < n; j++)
                {
                    if (((1 << j) & i) != 0 && (numOf % (j + 1) == 0 || (j + 1) % numOf == 0))
                    {
                        dp[i] += dp[i ^ (1 << j)];
                    }
                }
            }
            return dp[(1 << n) - 1];
        }
        int getOne(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i = i + (i >> 8);
            i = i + (i >> 16);
            return i & 0x3f;
        }
    }
}
