using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _553_OptimalDivision
    {
        public string OptimalDivision(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(nums[0]);
            if (nums.Length == 1)
            {
                return sb.ToString();
            }
            if (nums.Length > 2)
            {
                sb.Append('/');
                sb.Append('(');
                sb.Append(nums[1]);
                sb.Append('/');
            }
            else
            {
                sb.Append('/');
                sb.Append(nums[1]);
                return sb.ToString();
            }
            for (int i = 2; i < nums.Length - 1; i++)
            {
                sb.Append(nums[i]);
                sb.Append('/');
            }
            if (nums.Length > 2)
            {
                sb.Append(nums[nums.Length - 1]);
                sb.Append(')');
            }
            return sb.ToString();
        }
    }
}
