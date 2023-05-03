using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _90_SubsetsWithDup
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            dfs(nums, 0, res, new List<int>());
            return res;
        }

        void dfs(int[] nums, int cuurentNumber, IList<IList<int>> res, List<int> list)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                tempList.Add(list[i]);
            }
            res.Add(tempList);
            for (int i = cuurentNumber; i < nums.Length; i++)
            {
                if (i > cuurentNumber && nums[i] == nums[i - 1])
                {
                    continue;
                }
                list.Add(nums[i]);
                dfs(nums, i + 1, res, list);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
