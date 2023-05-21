using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length - 1;
            int cur = 0;
            while (cur <= len)
            {
                if (nums[cur] == val)
                {
                    Swap(nums, len, cur);
                    len--;
                }
                else
                {
                    cur++;
                }
            }
            return len + 1;
        }
        void Swap(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
