using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _268_MissingNumber
    {
        //给定一个包含 [0, n] 中 n 个数的数组 nums ，找出 [0, n] 这个范围内没有出现在数组中的那个数。
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            bool isN = true;
            int isZ = -1;
            for (int i = 0; i < n; i++)
            {
                int cur = Math.Abs(nums[i]);
                if (cur < n)
                {
                    if (nums[cur] == 0)
                    {
                        isZ = cur;
                    }
                    else
                    {
                        nums[cur] *= -1;
                    }
                }
                else
                {
                    isN = false;
                }
            }
            if (isN)
            {
                return n;
            }
            for (int j = 1; j < n; j++)
            {
                if (nums[j] > 0)
                {
                    return j;
                }
                if (nums[j] == 0)
                {
                    if (isZ != j)
                    {
                        return j;
                    }
                }
            }
            return 0;
        }
    }
}
