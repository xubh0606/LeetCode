using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _368_LargestDivisibleSubset
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            Array.Sort(nums);
            int[] dp = new int[nums.Length];
            int max = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int j = 0;
                while (j < i && nums[j] <= nums[i] / 2)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                    j++;
                }
                if (dp[i] > max)
                {
                    max = dp[i];
                    index = i;
                }
            }
            IList<int> res = new List<int>();
            res.Add(nums[index]);
            int num = nums[index];
            max--;
            for (int i = index - 1; i >= 0; i--)
            {
                if (num % nums[i] == 0 && dp[i] == max)
                {
                    max--;
                    num = nums[i];
                    res.Add(nums[i]);
                }
                if (max < 0)
                {
                    break;
                }
            }
            return res;
        }
    }
}
