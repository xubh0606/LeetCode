using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _300_LengthOfLIS
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] cur_lenMax = new int[nums.Length];
            cur_lenMax[0] = nums[0];
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > cur_lenMax[count])
                {
                    count++;
                    cur_lenMax[count] = nums[i];
                }
                else
                {
                    FindFirstSmaller(cur_lenMax, 0, count, nums[i]);
                }
            }
            return count + 1;
        }
        void FindFirstSmaller(int[] cur_lenMax, int left, int right, int target)
        {
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (cur_lenMax[mid] >= target)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            cur_lenMax[left] = target;
        }
    }
}
