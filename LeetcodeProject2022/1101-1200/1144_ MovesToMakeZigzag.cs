using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1144_MovesToMakeZigzag
    {
        public int MovesToMakeZigzag(int[] nums)
        {
            int count1 = 0;//以count1和2记录总移动数量
            int end = nums.Length - 1;
            if (end == 0)
            {
                return 0;
            }
            if (end > 0)
            {
                count1 += Math.Max(0, nums[0] - nums[1] + 1);
            }
            for (int i = 2; i < end; i += 2)
            {//对奇数为高点时降低偶数位的数字
                int min = Math.Min(nums[i - 1], nums[i + 1]);
                count1 += Math.Max(0, nums[i] - min + 1);
            }
            int count2 = 0;
            for (int i = 1; i < end; i += 2)
            {//对偶数为高点时降低奇数位的数字
                int min = Math.Min(nums[i - 1], nums[i + 1]);
                count2 += Math.Max(0, nums[i] - min + 1);
            }
            if (end % 2 == 0)
            {
                count1 += Math.Max(0, nums[end] - nums[end - 1] + 1);
            }
            else
            {
                count2 += Math.Max(0, nums[end] - nums[end - 1] + 1);
            }
            return Math.Min(count1, count2);
        }
    }
}
