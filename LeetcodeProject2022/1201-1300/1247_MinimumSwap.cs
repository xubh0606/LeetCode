using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300
{
    public class _1247_MinimumSwap
    {
        public int MinimumSwap(string s1, string s2)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (s1[i] == 'x')
                    {
                        count1++;
                    }
                    else
                    {
                        count2++;
                    }
                }
            }
            if ((count1 + count2) % 2 == 1)
            {
                return -1;
            }
            int sum = count1 / 2 + count2 / 2 + count1 % 2 + count2 % 2;
            return sum;
        }
    }
}
