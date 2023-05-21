using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _75_SortColors
    {
        public void SortColors(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
            }
            int left = 0;
            for (int i = count; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    while (nums[left] == 0)
                    {
                        left++;
                    }
                    Swap(nums, left, i);
                }
            }
            left = count;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] == 1)
                {
                    left++;
                    continue;
                }
                if (nums[right] == 2)
                {
                    right--;
                    continue;
                }
                Swap(nums, left, right);
                left++;
                right--;
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
