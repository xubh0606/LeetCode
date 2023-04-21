using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _254_GetFactors
    {
        IList<IList<int>> res;
        public IList<IList<int>> GetFactors(int n)
        {
            res = new List<IList<int>>();
            TrackBack(new List<int>(), 2, n);
            return res;
        }
        void TrackBack(IList<int> list, int factor, int n)
        {
            double maxFactor = Math.Sqrt(n);
            for (int i = factor; i <= (int)maxFactor; i++)
            {
                if (n % i == 0)
                {
                    IList<int> temp = new List<int>(list);
                    temp.Add(i);
                    temp.Add(n / i);
                    res.Add(temp);
                    list.Add(i);
                    TrackBack(list, i, n / i);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
