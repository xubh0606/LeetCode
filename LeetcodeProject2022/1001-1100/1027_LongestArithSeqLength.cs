using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1027_LongestArithSeqLength
    {
        public int LongestArithSeqLength(int[] nums)
        {
            int len = nums.Length;
            Dictionary<int, IList<int>> numSet = new Dictionary<int, IList<int>>();
            for (int i = 0; i < len; i++)
            {
                int num = nums[i];
                if (numSet.ContainsKey(num))
                {
                    numSet[num].Add(i);
                }
                else
                {
                    numSet.Add(num, new List<int>());
                    numSet[num].Add(i);
                }
            }
            int max = 2;
            for (int i = 0; i < len - max; i++)
            {
                for (int j = i + 1; j < len - max + 1; j++)
                {
                    int up = nums[i] * 2 - nums[j];
                    if (numSet.ContainsKey(up) && numSet[up][0] < i)
                    {
                        continue;
                    }
                    int next = nums[j] * 2 - nums[i];
                    int grow = nums[j] - nums[i];
                    int count = 1;
                    int startIndex = j;
                    while (startIndex != -1)
                    {
                        startIndex = FindNext(next, startIndex, nums, numSet);
                        next += grow;
                        count++;
                    }
                    max = Math.Max(count, max);
                }
            }
            return max;
        }
        int FindNext(int next, int startIndex, int[] nums, Dictionary<int, IList<int>> numSet)
        {
            if (numSet.ContainsKey(next))
            {
                IList<int> list = numSet[next];
                int right = list.Count - 1;
                if (list[right] <= startIndex)
                {
                    return -1;
                }
                int left = 0;
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (list[mid] > startIndex)
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                return list[left];
            }
            return -1;
        }
    }
}
