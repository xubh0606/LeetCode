using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1200_MinimumAbsDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = Math.Min(min, arr[i + 1] - arr[i]);
            }
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i + 1] - arr[i]) == min)
                {
                    IList<int> pair = new List<int>();
                    pair.Add(arr[i]);
                    pair.Add(arr[i + 1]);
                    res.Add(pair);
                }
            }
            return res;
        }
    }
}
