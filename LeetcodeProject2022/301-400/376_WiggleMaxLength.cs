using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _376_WiggleMaxLength
    {
        public int WiggleMaxLength(int[] nums)
        {
            if (nums.Length < 2)
            {
                return 1;
            }
            int up = 1;
            int down = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    down = up + 1;
                }
                if (nums[i] < nums[i - 1])
                {
                    up = down + 1;
                }
            }
            return Math.Max(up, down);
        }
    }
}
