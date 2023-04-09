using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    //超级丑数 是一个正整数，并满足其所有质因数都出现在质数数组 primes 中。
    //给你一个整数 n 和一个整数数组 primes ，返回第 n 个 超级丑数 。
    //题目数据保证第 n 个 超级丑数 在 32-bit 带符号整数范围内。
    public class _313_NthSuperUglyNumber
    {
        public int NthSuperUglyNumber(int n, int[] primes)
        {
            int[] dp = new int[n];
            dp[0] = 1;
            int[] point = new int[primes.Length];

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
