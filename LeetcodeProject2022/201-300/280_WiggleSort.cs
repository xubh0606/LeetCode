using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _280_WiggleSort
    {
        public void WiggleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (((i & 1) == 1) == (nums[i] < nums[i + 1]))
                {
                    Swap(nums, i);
                }
            }
        }
        void Swap(int[] nums, int i)
        {
            int temp = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = temp;
        }
    }
}
