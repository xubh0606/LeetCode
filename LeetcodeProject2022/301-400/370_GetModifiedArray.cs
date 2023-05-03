using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _370_GetModifiedArray
    {
        public int[] GetModifiedArray(int length, int[][] updates)
        {
            int[] totalUp = new int[length];
            for (int i = 0; i < updates.Length; i++)
            {
                totalUp[updates[i][0]] += updates[i][2];
                if (updates[i][1] < length - 1)
                {
                    totalUp[updates[i][1] + 1] -= updates[i][2];
                }
            }
            for (int i = 1; i < length; i++)
            {
                totalUp[i] += totalUp[i - 1];
            }
            return totalUp;
        }
    }
}
