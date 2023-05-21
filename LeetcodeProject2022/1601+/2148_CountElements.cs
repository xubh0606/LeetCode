using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _2148_CountElements
    {
        public int CountElements(int[] nums)
        {
            IList<int> list = new List<int>();
            list.Add(nums[0]);
            int max = nums[0];
            int min = max;
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    list.Add(nums[i]);
                    continue;
                }
                if (nums[i] < min)
                {
                    list.Add(nums[i]);
                    min = nums[i];
                    continue;
                }
                if (nums[i] > min && nums[i] < max)
                {
                    count++;
                }
                else
                {
                    list.Add(nums[i]);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > min && list[i] < max)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
