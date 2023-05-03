using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _55_CanJump
    {
        //动态规划算法，每次考虑上一个情况累加即可
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }
            if (nums[0] == 0)
            {
                return false;
            }
            int[] canJump = new int[nums.Length];
            canJump[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (canJump[i - 1] >= i)
                {
                    canJump[i] = Math.Max(i + nums[i], canJump[i - 1]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
