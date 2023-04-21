using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _891_SumSubseqWidths
    {
        public int SumSubseqWidths(int[] nums)
        {
            int MOD = 1000000007;
            Array.Sort(nums);
            long res = 0;
            long leftSum = nums[0];
            long right = 2;
            for (int i = 1; i < nums.Length; i++)
            {
                res += nums[i] * (right - 1) - leftSum;
                res %= MOD;
                leftSum = (leftSum * 2 + nums[i]) % MOD;
                right *= 2;
                right %= MOD;
            }
            return (int)((res + MOD) % MOD);
        }
    }
}
