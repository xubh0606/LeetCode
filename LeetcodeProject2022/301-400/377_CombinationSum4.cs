using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _377_CombinationSum4
    {
        public int CombinationSum4(int[] nums, int target)
        {
            int[] dp = new int[target + 1];
            Array.Sort(nums);
            int len = 0;
            for (; len < nums.Length; len++)
            {
                if (nums[len] > target)
                {
                    break;
                }
            }
            dp[0] = 1;
            for (int i = 0; i < target; i++)
            {
                if (dp[i] == 0)
                {
                    continue;
                }
                for (int j = 0; j < len; j++)
                {
                    int sum = i + nums[j];
                    if (sum > target)
                    {
                        break;
                    }
                    dp[sum] += dp[i];
                }
            }
            return dp[target];
        }
    }
}
