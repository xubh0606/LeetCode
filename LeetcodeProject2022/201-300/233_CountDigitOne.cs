using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _233_CountDigitOne
    {
        public int CountDigitOne(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            int dividend = 1;
            int cur_n = n;
            while (cur_n / dividend >= 10)
            {
                dividend *= 10;
            }
            int sum = 0;
            int head = 0;
            int total = 0;
            while (dividend != 0)
            {
                int remainder = cur_n / dividend;
                cur_n = cur_n % dividend;
                if (remainder == 0)
                {
                    total = 0;
                }
                else if (remainder > 1)
                {
                    total = dividend;
                }
                else
                {
                    total = cur_n + 1;
                }
                sum = sum + total + head * dividend;
                head = head * 10 + remainder;
                dividend /= 10;
            }
            return sum;
        }
    }
}
