using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _621_LeastInterval
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int[] t = new int[26];
            int time = tasks.Length;
            for (int i = 0; i < time; i++)
            {
                t[tasks[i] - 'A']++;
            }
            int maxCount = 0;
            int times = 0;
            for (int j = 0; j < 26; j++)
            {
                if (t[j] > maxCount)
                {
                    maxCount = t[j];
                    times = 1;
                }
                else if (t[j] == maxCount)
                {
                    times++;
                }
            }
            if ((maxCount - 1) * (n + 1) + times < tasks.Length)
            {
                return tasks.Length;
            }
            return (maxCount - 1) * (n + 1) + times;
        }
    }
}
