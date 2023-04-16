using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _805_SplitArraySameAverage
    {
        public bool SplitArraySameAverage(int[] nums)
        {
            int total = 0;
            int len = nums.Length;
            for(int i = 0; i < len; i++)
            {
                total += nums[i];
            }
            for (int i = 0; i < len; i++)
            {
                nums[i] = nums[i] * len - total;
            }
            int max = len / 2;
            HashSet<int> set = new HashSet<int>();
            int maxLeft = 0;
            for (int i = 0; i < max; i++)
            {
                maxLeft += nums[i];
            }
            if (maxLeft == 0)
            {
                return true;
            }
            GetSet(set, 0, max, 0, nums);
            set.Remove(maxLeft);
            if (set.Contains(0))
            {
                return true;
            }
            set.Add(0);
            if (FindSet(set, max, len, 0, nums))
            {
                return true;
            }
            return false;
        }
        bool FindSet(HashSet<int> set, int curIndex, int max, int sum, int[] nums)
        {
            if (curIndex >= max)
            {
                return false;
            }
            if (FindSet(set, curIndex + 1, max, sum, nums))
            {
                return true;
            }
            sum += nums[curIndex];
            if (set.Contains(0 - sum))
            {
                return true;
            }
            return FindSet(set, curIndex + 1, max, sum, nums);
        }
        void GetSet(HashSet<int> set, int curIndex, int max, int sum, int[] nums)
        {
            if (curIndex >= max)
            {
                return;
            }
            GetSet(set, curIndex + 1, max, sum, nums);
            sum += nums[curIndex];
            set.Add(sum);
            GetSet(set, curIndex + 1, max, sum, nums);
        }
    }
}
