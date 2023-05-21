using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _91_NumDecodings
    {
        public int NumDecodings(string s)
        {
            if (s[0] == '0')
            {
                return 0;
            }
            int n = s.Length;
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 1; i < n; i++)
            {
                if (CheakTwo(s[i - 1], s[i]))
                {
                    dp[i + 1] = dp[i - 1];
                }
                if (s[i] != '0')
                {
                    dp[i + 1] += dp[i];
                }
            }
            return dp[n];
        }
        bool CheakTwo(char c1, char c2)
        {
            if (c1 == '0' || c1 > '2')
            {
                return false;
            }
            if (c1 == '1')
            {
                return true;
            }
            if (c2 < '7')
            {
                return true;
            }
            return false;
        }
    }
}
