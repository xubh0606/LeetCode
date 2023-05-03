using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _410_SplitArray
    {
        public int SplitArray(int[] nums, int k)
        {
            int len = nums.Length;
            int[,] dp = new int[len + 1, k];
            int[] sum = new int[len + 1];
            for (int i = 0; i < len; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
            }
            for (int i = 0; i <= len; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }
            k--;
            dp[0, 0] = 0;
            for (int i = 1; i < len; i++)
            {
                for (int j = 1; j <= Math.Min(k, i); j++)
                {
                    for (int end = 0; end < i; end++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], Math.Max(dp[end, j - 1], sum[i] - sum[end]));
                    }
                }
            }
            int res = int.MaxValue;
            for (int i = k; i < len; i++)
            {
                res = Math.Min(res, Math.Max(dp[i, k], sum[len] - sum[i]));
            }
            return res;
        }
    }
}
