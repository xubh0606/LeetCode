using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1124_LongestWPI
    {
        public int LongestWPI(int[] hours)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            set.Add(0, -1);
            if (hours[0] > 8)
            {
                hours[0] = 1;
            }
            else
            {
                hours[0] = -1;
            }
            set.Add(hours[0], 0);
            int max = 0;
            if(hours[0] == 1)
            {
                max++;
            }
            for (int i = 1; i < hours.Length; i++)
            {
                if (hours[i] > 8)
                {
                    hours[i] = hours[i - 1] + 1;
                }
                else
                {
                    hours[i] = hours[i - 1] - 1;
                }
                if (!set.ContainsKey(hours[i]))
                {
                    set.Add(hours[i], i);
                }
                if (set.ContainsKey(hours[i] - 1))
                {
                    max = Math.Max(max, i - set[hours[i] - 1]);
                }
            }
            if (hours[hours.Length - 1] > 0)
            {
                return hours.Length;
            }
            return max;
        }
    }
}
