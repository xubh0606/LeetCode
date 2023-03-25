using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _34_SearchRange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int[] res = new int[2];
            if (nums.Length == 0 || nums[left] > target || nums[right] < target)
            {
                res[0] = -1;
                res[1] = -1;
                return res;
            }
            while (nums[left] < target && nums[right] > target)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    break;
                }
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (nums[left] == target)
            {
                res[0] = left;
                res[1] = FindRight(nums, left, right, target);
                return res;
            }
            if (nums[right] == target)
            {
                res[1] = right;
                res[0] = FindLeft(nums, left, right, target);
                return res;
            }
            if (nums[left + (right - left) / 2] != target)
            {
                res[0] = -1;
                res[1] = -1;
                return res;
            }
            res[1] = FindRight(nums, left + (right - left) / 2, right, target);
            res[0] = FindLeft(nums, left, left + (right - left) / 2, target);
            return res;
        }
        int FindRight(int[] nums, int left, int right, int target)
        {
            while (left < right)
            {
                int mid = left + (right - left) / 2 + 1;
                if (nums[mid] == target)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
        int FindLeft(int[] nums, int left, int right, int target)
        {
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
