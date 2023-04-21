using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _162_FindPeakElement
    {
        public int FindPeakElement(int[] nums)
        {
            int i = 0;
            while (i < nums.Length - 1 && nums[i] < nums[i + 1])
            {
                i++;
            }
            return i;
        }
    }
}
