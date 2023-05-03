using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1004_LongestOnes
    {
        public int LongestOnes(int[] nums, int k)
        {
            int countZero = k;
            int right = 0;
            int left = 0;
            int max = 0;
            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    max = Math.Max(max, right - left);
                    countZero--;
                    while (countZero < 0)
                    {
                        if (nums[left] == 0)
                        {
                            countZero++;
                        }
                        left++;
                    }
                }
                right++;
            }
            max = Math.Max(max, right - left);
            return max;
        }
    }
}
