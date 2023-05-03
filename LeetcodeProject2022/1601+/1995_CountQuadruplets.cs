using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _1995_CountQuadruplets
    {
        public int CountQuadruplets(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    int sumTwo = nums[i] + nums[j];
                    for (int k = j + 1; k < nums.Length - 1; k++)
                    {
                        for (int d = k + 1; d < nums.Length; d++)
                        {
                            if (nums[k] + sumTwo == nums[d])
                            {
                                res++;
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
