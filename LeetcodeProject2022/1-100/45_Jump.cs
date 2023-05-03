using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _45_Jump
    {
        public int Jump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int[] dp = new int[nums.Length];
            dp[nums.Length - 1] = 1;
            GetMinJump(nums, dp, 0);
            return dp[0] - 1;
        }
        void GetMinJump(int[] nums, int[] dp, int start)
        {
            int min = int.MaxValue;
            for (int i = start + 1; i < nums.Length && i <= nums[start] + start; i++)
            {
                if (dp[i] == 0)
                {
                    GetMinJump(nums, dp, i);
                }
                if (dp[i] == -1)
                {
                    continue;
                }
                min = Math.Min(min, dp[i]);
            }
            if (min == int.MaxValue)
            {
                dp[start] = -1;
            }
            else
            {
                dp[start] = min+1;
            }
        }
    }
}
