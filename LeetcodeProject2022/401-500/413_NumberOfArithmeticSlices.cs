using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _413_NumberOfArithmeticSlices
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            int len = nums.Length;
            if (len < 3)
            {
                return 0;
            }
            int sum = 0;
            int[] dp = new int[len];
            //以i结尾的等差子数组数目
            int last = nums[1] - nums[0];
            for (int i = 2; i < len; i++)
            {
                if (nums[i] - nums[i - 1] == last)
                {
                    dp[i] = dp[i - 1] + 1;
                    sum += dp[i];
                }
                else
                {
                    dp[i] = 0;
                    last = nums[i] - nums[i - 1];
                }
            }
            return sum;
        }
    }
}
