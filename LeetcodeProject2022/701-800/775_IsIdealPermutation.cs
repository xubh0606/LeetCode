using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _775_IsIdealPermutation
    {
        public bool IsIdealPermutation(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (nums[i] != i + 1)
                    {
                        return false;
                    }
                    if (nums[i + 1] != i)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
