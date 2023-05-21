using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _81_Search
    {
        public bool Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            return SearchTarget(left, right, nums, target);
        }
        bool SearchTarget(int left, int right, int[] nums, int target)
        {
            if (left >= right)
            {
                return nums[left] == target;
            }
            //判断在两段不同升序中的位置
            while (left < right)
            {
                int numL = nums[left];
                int numR = nums[right];
                if (numL == target || numR == target)
                {
                    return true;
                }
                int mid = left + (right - left) / 2;
                int numM = nums[mid];
                if (numM == target)
                {
                    return true;
                }
                //完全一致时无法判断，只能同时考虑两侧递归解答
                if (numM == numL && numM == numR)
                {
                    return SearchTarget(left + 1, mid - 1, nums, target) || SearchTarget(mid + 1, right - 1, nums, target);
                }
                //此时中点在上侧
                else if (numM < numL)
                {
                    //去右侧找。此时已经变成单调序列
                    if (target > numM && target < numL)
                    {
                        return Find(nums, mid + 1, right, target);
                    }
                    //去左侧找
                    else
                    {
                        right = mid - 1;
                    }
                }
                //此时中点在下侧
                else
                {
                    //去右侧找，也变成单调序列
                    if (target > numL && target < numM)
                    {
                        return Find(nums, left, mid - 1, target);
                    }
                    //去左侧找
                    else
                    {
                        left = mid + 1;
                        numL = nums[left];
                    }
                }
            }
            return false;
        }
        //单调序列直接找
        bool Find(int[] nums, int left, int right, int target)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return true;
                }
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}
