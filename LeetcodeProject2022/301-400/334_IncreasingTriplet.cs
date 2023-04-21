using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _334_IncreasingTriplet
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int[] min = new int[2];
            min[0] = int.MaxValue;
            min[1] = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= int.MaxValue)
                {
                    if (nums[i] > min[1])
                    {
                        return true;
                    }
                    else if (nums[i] > min[0])
                    {
                        min[1] = nums[i];
                    }
                    else
                    {
                        min[0] = nums[i];
                    }
                }
            }
            return false;
        }
    }
}
