using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _41_FirstMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            //二分查找第一个缺失数字
            int left = 0;
            int n = nums.Length;
            int right = n - 1;
            while (left < right)
            {
                if (nums[left] <= 0)
                {
                    left++;
                    continue;
                }
                if (nums[right] > 0)
                {
                    right--;
                    continue;
                }
                swap(left, right, nums);
                left++;
                right--;
            }
            int lefti;
            if (nums[right] < 1)
            {
                if (right == n - 1)
                {
                    return 1;
                }
                lefti = right + 1;
            }
            else
            {
                lefti = right;
            }
            int start = lefti;
            int righti = n - 1;
            while (lefti < righti)
            {
                if (nums[lefti] <= 500001)
                {
                    lefti++;
                    continue;
                }
                if (nums[righti] > 500001)
                {
                    righti--;
                    continue;
                }
                swap(lefti, righti, nums);
                lefti++;
                righti--;
            }
            if (left != righti)
            {
                Array.Sort(nums, start, lefti - start + 1);
            }
            int res = 1;
            for (int i = left; i <= lefti;)
            {
                if (nums[i] == res)
                {
                    res++;
                    i++;
                }
                else if (res > nums[i])
                {
                    i++;
                }
                else
                {
                    return res;
                }
            }
            return res;
        }
        void swap(int left, int right, int[] nums)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
    }
}
