using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _47_PermuteUnique
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            TrackBack(nums, res, new List<int>(), 0);
            return res;
        }
        //用visited在所有层之间建立排除
        void TrackBack(int[] nums, IList<IList<int>> res, IList<int> list, int visited)
        {
            if (list.Count == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }
            //在当前层进行排除
            bool[] visitedNow = new bool[21];
            for (int i = 0; i < nums.Length; i++)
            {
                int place = (1 << i);
                if ((place & visited) == 0)
                {
                    if (visitedNow[nums[i] + 10])
                    {
                        continue;
                    }
                    list.Add(nums[i]);
                    visited += place;
                    visitedNow[nums[i] + 10] = true;
                    TrackBack(nums, res, list, visited);
                    list.RemoveAt(list.Count - 1);
                    visited -= place;
                }
            }
        }
    }
}
