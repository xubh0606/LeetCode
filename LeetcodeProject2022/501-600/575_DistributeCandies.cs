using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _575_DistributeCandies
    {
        public int DistributeCandies(int[] candyType)
        {
            HashSet<int> diferentType = new HashSet<int>();
            for (int i = 0; i < candyType.Length; i++)
            {
                if (!diferentType.Contains(candyType[i]))
                {
                    diferentType.Add(candyType[i]);
                }
            }
            return Math.Min(candyType.Length / 2, diferentType.Count);
        }
    }
}
