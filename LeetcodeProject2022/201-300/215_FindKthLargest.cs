using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._201_300
{
    public class _215_FindKthLargest
    {
        Random m_random;
        public int FindKthLargest(int[] nums, int k)
        {
            m_random = new Random();
            int len = nums.Length;
            return FindK(nums, 0, len, len - k);
        }
        int FindK(int[] nums, int left, int right, int k)
        {
            if(right == left + 1)
            {
                return nums[left];
            }
            if (right == left + 2)
            {
                if(k == left)
                {
                    if(nums[left] > nums[left + 1])
                    {
                        return nums[left + 1];
                    }
                    return nums[left];
                }
                else
                {
                    if (nums[left] > nums[left + 1])
                    {
                        return nums[left];
                    }
                    return nums[left + 1];
                }
            }
            int lastLeft = left;
            int p = m_random.Next(left, right);
            int center = nums[p];
            Swap(nums, p, right - 1);
            p = right - 1;
            right -= 2;
            while (left < right)
            {
                if (nums[left] < center)
                {
                    left++;
                    continue;
                }
                if (nums[right] > center)
                {
                    right--;
                    continue;
                }
                Swap(nums, left, right);
                left++;
                right--;
            }
            if(nums[left] < center)
            {
                left++;
            }
            Swap(nums, left, p);
            if (left == k)
            {
                return nums[left];
            }
            if (left > k)
            {
                return FindK(nums, lastLeft, left, k);
            }
            else
            {
                return FindK(nums, left + 1, p + 1, k);
            }
        }
        void Swap(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
