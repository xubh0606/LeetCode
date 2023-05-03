using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _862_ShortestSubarray
    {
        public int ShortestSubarray(int[] nums, int k)
        {
            int n = nums.Length;
            long[] sums = new long[n + 1];
            int min = int.MaxValue;
            LinkedList<int> subarrayStart = new LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                sums[i + 1] = sums[i] + nums[i];
            }
            for (int i = 0; i <= n; i++)
            {
                while (subarrayStart.Count > 0 && sums[subarrayStart.Last.Value] > sums[i])
                {
                    subarrayStart.RemoveLast();
                }
                while (subarrayStart.Count > 0 && sums[i] - sums[subarrayStart.First.Value] >= k)
                {
                    min = Math.Min(min, i - subarrayStart.First.Value);
                    subarrayStart.RemoveFirst();
                }
                subarrayStart.AddLast(i);
            }
            return min == int.MaxValue ? -1 : min;
        }
    }
}
