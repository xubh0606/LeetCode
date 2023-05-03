using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _53_MaxSubArray
    {
        //动态规划，只有当前和大于0时考虑累积，否则归零，最后取其中最大的值。
        public int MaxSubArray(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            int max = dp[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (dp[i - 1] < 0)
                {
                    dp[i] = nums[i];
                }
                else
                {
                    dp[i] = nums[i] + dp[i - 1];
                }
                if (max < dp[i])
                {
                    max = dp[i];
                }
            }
            return max;
        }
    }
}
