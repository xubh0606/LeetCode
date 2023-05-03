using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _343_IntegerBreak
    {
        //给定一个正整数 n ，将其拆分为 k 个 正整数 的和（ k >= 2 ），并使这些整数的乘积最大化。
        public int IntegerBreak(int n)
        {
            int[] maxProduct = new int[n + 1];
            maxProduct[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                maxProduct[i - 1] = Math.Max(i - 1, maxProduct[i - 1]);
                int max = 0;
                for (int j = 1; j < i; j++)
                {
                    max = Math.Max(maxProduct[j] * (i - j), max);
                }
                maxProduct[i] = max;
            }
            return maxProduct[n];
        }
    }
}
