using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _442_FindDuplicates
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = Math.Abs(nums[i]);
                if (nums[cur - 1] > 0)
                {
                    nums[cur - 1] *= -1;
                }
                else
                {
                    list.Add(cur);
                }
            }
            return list;
        }
    }
}
