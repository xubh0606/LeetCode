using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _39_CombinationSumSolution
    {
        //对数组排序之后，按照数字从小到大依次尝试添加，超出后剩余数字必然超出。每得到一个就加入res中，最后返回答案。
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> res = new List<IList<int>>();

            dfs(candidates, target, 0, res, new List<int>());

            return res;
        }

        void dfs(int[] candidates, int target, int currentNumber, IList<IList<int>> res, List<int> list)
        {
            if (target == 0)
            {
                res.Add(new List<int>(list));
            }
            for (int i = currentNumber; i < candidates.Length; i++)
            {
                if (target - candidates[i] < 0)
                {
                    break;
                }
                target = target - candidates[i];
                list.Add(candidates[i]);
                dfs(candidates, target, i, res, list);
                list.RemoveAt(list.Count - 1);
                target = target + candidates[i];
            }
        }
    }
}
