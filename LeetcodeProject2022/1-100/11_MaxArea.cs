using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _11_MaxArea
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int max = 0;
            while (left < right)
            {
                int temp = Math.Min(height[left], height[right]);
                max = Math.Max(temp * (right - left), max);
                if (temp == height[left])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return max;
        }
    }
}
