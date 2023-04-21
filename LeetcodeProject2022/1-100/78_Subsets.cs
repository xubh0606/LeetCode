using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._1_200
{
    public class _78_Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
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
                list.Add(nums[i]);
                dfs(nums, i + 1, res, list);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
