using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _152_MaxProduct
    {
        public int MaxProduct(int[] nums)
        {
            //存储当前最大正数和最小负数，然后得出最大最终正数
            int max = int.MinValue;
            int n = nums.Length;
            int[,] dp = new int[n + 1, 2];
            for (int i = 0; i < n; i++)
            {
                int cur = nums[i];
                if (cur == 0)
                {
                    dp[i + 1, 0] = 0;
                    dp[i + 1, 1] = 0;
                    max = Math.Max(0, max);
                }
                else if (cur > 0)
                {
                    dp[i + 1, 0] = Math.Max(dp[i, 0] * cur, cur);
                    dp[i + 1, 1] = dp[i, 1] * cur;
                    max = Math.Max(dp[i + 1, 0], max);
                }
                else
                {
                    dp[i + 1, 0] = dp[i, 1] * cur;
                    dp[i + 1, 1] = Math.Min(dp[i, 0] * cur, cur);
                    if (dp[i + 1, 0] > 0)
                    {
                        max = Math.Max(dp[i + 1, 0], max);
                    }
                    else
                    {
                        max = Math.Max(max, dp[i + 1, 1]);
                    }
                }
            }
            return max;
        }
    }
}
