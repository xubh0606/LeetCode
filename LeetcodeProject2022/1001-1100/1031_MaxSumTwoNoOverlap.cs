using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1031_MaxSumTwoNoOverlap
    {
        public int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
        {
            int[] sumNums = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                sumNums[i + 1] = sumNums[i] + nums[i];
            }
            int maxFirst = 0;
            int maxSecond = 0;
            int maxTotal = 0;
            for (int i = firstLen + secondLen; i <= nums.Length; i++)
            {
                int last = sumNums[i - firstLen - secondLen];
                maxFirst = Math.Max(maxFirst, sumNums[i - firstLen] - last);
                maxSecond = Math.Max(maxSecond, sumNums[i - secondLen] - last);
                maxTotal = Math.Max(maxTotal, maxFirst + sumNums[i] - sumNums[i - firstLen]);
                maxTotal = Math.Max(maxTotal, maxSecond + sumNums[i] - sumNums[i - secondLen]);
            }
            return maxTotal;
        }
    }
}
