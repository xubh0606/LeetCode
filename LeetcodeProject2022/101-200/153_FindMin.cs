using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _153_FindMin
    {//每次移动后考虑当前位置，可以分:恰好升序，开头在左侧，开头在右侧
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int leftNum = nums[left];
                int mid = left + (right - left) / 2;
                int midNum = nums[mid];
                if (midNum >= leftNum)
                {
                    if (midNum < nums[right])
                    {
                        break;
                    }
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }
    }
}
