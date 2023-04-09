using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _357_CountNumbersWithUniqueDigits
    {
        //给你一个整数 n ，统计并返回各位数字都不同的数字 x 的个数，其中 0 <= x < 10n 。
        public int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 10;
            }
            int res = 10;
            int cur = 9;
            for (int i = 0; i < n - 1; i++)
            {
                cur *= 9 - i;
                res += cur;
            }
            return res;
        }
    }
}
