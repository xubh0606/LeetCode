using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _259_ThreeSumSmaller
    {
        //给定一个长度为 n 的整数数组和一个目标值 target 
        //寻找能够使条件 nums[i] + nums[j] + nums[k] < target 成立的三元组  i, j, k 个数（0 <= i < j < k < n）。

        public int ThreeSumSmaller(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int k = nums.Length - 1; k > 1; k--)
            {
                for (int j = k - 1; j > 0; j--)
                {
                    int max = target - nums[k] - nums[j];
                    if (nums[0] < max)
                    {
                        int lastI = Find(nums, max, j - 1);
                        sum += lastI + 1;
                    }
                }
            }
            return sum;
        }
        int Find(int[] nums, int max, int right)
        {
            int left = 0;
            while (left < right)
            {
                int mid = left + (right - left) / 2 + 1;
                if (nums[mid] < max)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return right;
        }
    }
}
