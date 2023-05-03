using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1480_RunningSum
    {
        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            runningSum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
            }
            return runningSum;
        }
    }
}
