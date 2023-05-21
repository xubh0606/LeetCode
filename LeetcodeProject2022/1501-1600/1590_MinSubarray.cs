using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1590_MinSubarray
    {
        public int MinSubarray(int[] nums, int p)
        {
            //注意是子数组！所以可以通过两个前缀和之差直接找到！要求为(a-b)%P == sum%p
            Dictionary<int, IList<int>> visited = new Dictionary<int, IList<int>>();
            //存储每次遇到的余数值.0为特例提前加入
            visited.Add(0, new List<int>());
            visited[0].Add(0);
            int[] sums = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                sums[i + 1] = (nums[i] + sums[i]) % p;
                if (!visited.ContainsKey(sums[i + 1]))
                {
                    visited.Add(sums[i + 1], new List<int>());
                    visited[sums[i + 1]].Add(i + 1);
                }
                else
                {
                    //代表着当前值余数
                    visited[sums[i + 1]].Add(i + 1);
                }
            }
            int sum = sums[nums.Length];
            if (sum == 0)
            {
                return 0;
            }
            int res = nums.Length;
            for (int i = 0; i <= nums.Length; i++)
            {
                //target值是当前点与某个特定点满足删除后刚好剩下为0+n*p
                int target = (sums[i] - sum + p) % p;
                //位移后看是 sum = sums[i] - target ！！！！
                if (visited.ContainsKey(target) && visited[target][0] < i)
                {
                    res = Math.Min(res, i - FindClose(visited, target, i));
                }
            }
            return res == nums.Length ? -1 : res;
        }
        int FindClose(Dictionary<int, IList<int>> visited, int target, int end)
        {
            //找最大的小于end的位置
            IList<int> list = visited[target];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] >= end)
                {
                    return end - 1;
                }
            }
            return list[list.Count - 1];
        }
    }
}
