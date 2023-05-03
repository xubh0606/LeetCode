using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1060_MissingElement
    {
        public int MissingElement(int[] nums, int k)
        {
            int start = nums[0];
            //定义left <  k && left + 1 > k则left+1就是所求。
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if ((nums[mid] - start - mid) >= k)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return k + start + right;
        }
    }
}
