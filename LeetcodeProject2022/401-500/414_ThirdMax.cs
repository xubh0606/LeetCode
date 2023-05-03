using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._401_500
{
    public class _414_ThirdMax
    {
        int m_Chose;
        Random m_random;
        public int ThirdMax(int[] nums)
        {
            if (nums.Length < 3)
            {
                int max = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    max = Math.Max(max, nums[i]);
                }
                return max;
            }
            m_Chose = nums.Length - 3;
            m_random = new Random();
            FindKthBigNumber(nums, 0, nums.Length - 1);
            return nums[m_Chose];
        }
        int FindKthBigNumber(int[] nums, int left, int right)
        {
            if (right - left < 2)
            {
                if (right == m_Chose)
                {
                    if (nums[right] < nums[left])
                    {
                        return right;
                    }
                    return left;
                }
                else
                {
                    if (nums[right] < nums[left])
                    {
                        return left;
                    }
                    else
                    {
                        return right;
                    }
                }
            }
            int mid = m_random.Next(left, right);
            mid = GetMidPlace(nums, left, right, mid);
            if (mid > m_Chose)
            {
                return FindKthBigNumber(nums, left, mid);
            }
            else
            {
                return FindKthBigNumber(nums, mid, left);
            }
        }
        int GetMidPlace(int[] nums, int left, int right, int mid)
        {
            int midNum = nums[mid];
            Swap(nums, right, mid);
            mid = right;
            right--;
            while (left < right)
            {
                if (nums[left] < midNum)
                {
                    left++;
                    continue;
                }
                if (nums[right] > midNum)
                {
                    right--;
                    continue;
                }
                Swap(nums, left, right);
                left++;
                right--;
            }
            if (nums[left] >= midNum || left + 1 > nums.Length)
            {
                Swap(nums, mid, left);
                return left;
            }
            else
            {
                Swap(nums, mid, left + 1);
                return left + 1;
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
