using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _2094_FindEvenNumbers
    {
        public int[] FindEvenNumbers(int[] digits)
        {
            int[] NumbersCount = new int[11];
            for (int i = 0; i < digits.Length; i++)
            {
                NumbersCount[digits[i]]++;
            }
            int first = 0;
            List<int> res = new List<int>();
            for (int j = 1; j < 10; j++)
            {
                first++;
                if (NumbersCount[first] == 0)
                {
                    continue;
                }
                NumbersCount[first]--;
                for (int k = 0; k < 10; k++)
                {
                    if (NumbersCount[k] == 0)
                    {
                        continue;
                    }
                    int temp1 = first * 10 + k;
                    NumbersCount[k]--;
                    for (int l = 0; l < 10; l = l + 2)
                    {
                        if (NumbersCount[l] == 0)
                        {
                            continue;
                        }
                        res.Add(temp1 * 10 + l);
                    }
                    NumbersCount[k]++;
                }
                NumbersCount[first]++;
            }
            return res.ToArray();
        }
    }
}
