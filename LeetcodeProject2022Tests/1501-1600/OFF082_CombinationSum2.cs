using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022_1501_1600
{
    public class OFF082_CombinationSum2
    {
        //每种数字读取个数
        //对数字进行高级排序，原则是：同元素的多个按照叠加后依次加入计算（比如三个1就算作1,2,3）
        //后面为标准的无重复集合组合。
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> res = new List<IList<int>>();
            dfs(candidates, target, 0, new List<int>(), 0, res);
            return res;
        }
        void dfs(int[] candidates, int target, int currentNumber, List<int> list, int curTarget, IList<IList<int>> res)
        {
            if (target <= curTarget)
            {
                if (target == curTarget)
                {
                    res.Add(new List<int>(list));
                }
                return;
            }
            for (int i = currentNumber; i < candidates.Length; i++)
            {
                if (curTarget + candidates[i] > target)
                {
                    break;
                }
                if (i > currentNumber && candidates[i] == candidates[i - 1])
                {
                    continue;
                }
                curTarget += candidates[i];
                list.Add(candidates[i]);
                dfs(candidates, target, i + 1, list, curTarget, res);
                list.RemoveAt(list.Count - 1);
                curTarget -= candidates[i];
            }
        }
    }
}
