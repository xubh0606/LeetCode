using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _2048_NextBeautifulNumber
    {
        public int NextBeautifulNumber(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            int m = n + 1;
            while (!IsBeautifulNumber(m))
            {
                m++;
            }
            return m;
        }
        public bool IsBeautifulNumber(int i)
        {
            int[] temp = new int[10];
            while (i / 10 > 0)
            {
                if (i % 10 == 0)
                {
                    return false;
                }
                temp[i % 10]++;
                i = i / 10;
            }
            temp[i]++;
            for (int k = 1; k < 10; k++)
            {
                if (temp[k] != 0 && temp[k] != k)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
