using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _7_Reverse
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }
            int absX = Math.Abs(x);
            int res = 0;
            while (absX > 9)
            {
                res = res * 10 + absX % 10;
                absX /= 10;
            }
            if (res > int.MaxValue / 10)
            {
                return 0;
            }
            res = res * 10 + absX % 10;
            return x > 0 ? res : (-res);
        }
    }
}
