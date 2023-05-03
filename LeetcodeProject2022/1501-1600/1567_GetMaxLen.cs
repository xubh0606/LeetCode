using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1567_GetMaxLen
    {
        public int GetMaxLen(int[] nums)
        {
            int DEF = int.MaxValue;
            int firstNagetive = DEF;
            int firstNotNagetive = -1;
            int max = 0;
            int cur = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    firstNagetive = DEF;
                    firstNotNagetive = i;
                    cur = 1;
                }
                else if (nums[i] * cur > 0)
                {
                    max = Math.Max(i - firstNotNagetive, max);
                    cur = 1;
                }
                else
                {
                    if (firstNagetive == DEF)
                    {
                        firstNagetive = i;
                    }
                    max = Math.Max(i - firstNagetive, max);
                    cur = -1;
                }
            }
            return max;
        }
    }
}
