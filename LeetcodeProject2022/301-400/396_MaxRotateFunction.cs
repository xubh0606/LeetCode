using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _396_MaxRotateFunction
    {
        public int MaxRotateFunction(int[] nums)
        {
            int len = nums.Length;
            int[] dp = new int[len];
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                dp[0] += i * nums[i];
                sum += nums[i];
            }
            int max = dp[0];
            for (int i = 1; i < len; i++)
            {
                dp[i] = dp[i - 1] + sum - nums[len - i] * len;
                if (dp[i] > max)
                {
                    max = Math.Max(max, dp[i]);
                }
            }
            return max;
        }
    }
}
