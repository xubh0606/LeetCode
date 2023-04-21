using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._1_200
{
    public class _1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //数据设定为只有一种有效情况，则只需要一个长度为2的数组即可。
            int[] res = new int[2];
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int sum = nums[left] + nums[right];
                if(sum == target)
                {
                    res[0] = left;
                    res[1] = right;
                    return res;
                }
                if(sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return res;
        }
    }
}
