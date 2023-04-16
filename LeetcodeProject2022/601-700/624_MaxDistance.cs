using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _624_MaxDistance
    {
        public int MaxDistance(IList<IList<int>> arrays)
        {
            int min = arrays[0][0];
            int max = arrays[0][arrays[0].Count - 1];
            int maxDif = 0;
            for (int i = 1; i < arrays.Count; i++)
            {
                maxDif = Math.Max(maxDif, arrays[i][arrays[i].Count - 1] - min);
                maxDif = Math.Max(maxDif, max - arrays[i][0]);
                min = Math.Min(min, arrays[i][0]);
                max = Math.Max(max, arrays[i][arrays[i].Count - 1]);
            }
            return maxDif;
        }
    }
}
