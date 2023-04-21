using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _46_Permute
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            //回溯全排列情况
            IList<IList<int>> res = new List<IList<int>>();
            int n = nums.Length;
            HashSet<int> path = new HashSet<int>();
            TrackBack(nums, res, new List<int>(), n, path);
            return res;
        }

        void TrackBack(int[] nums, IList<IList<int>> res, List<int> list, int n, HashSet<int> path)
        {
            if (list.Count == n)
            {
                res.Add(new List<int>(list));
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (path.Contains(i))
                {
                    continue;
                }
                list.Add(nums[i]);
                path.Add(i);
                TrackBack(nums, res, list, n, path);
                path.Remove(i);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
