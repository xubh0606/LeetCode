using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _264_NthUglyNumber
    {
        public int NthUglyNumber(int n)
        {
            int[] dp = new int[n];
            dp[0] = 1;
            int[] primes = new int[] { 2, 3, 5 };
            int[] point = new int[3];

            for (int i = 1; i < n; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < primes.Length; j++)
                {
                    if (dp[point[j]] * primes[j] < 0) continue;
                    min = Math.Min(min, dp[point[j]] * primes[j]);

                }
                dp[i] = min;
                for (int j = 0; j < primes.Length; j++)
                {
                    if (min % primes[j] == 0)
                    {
                        point[j]++;
                    }
                }
            }
            return dp[n - 1];
        }
    }
}
