using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    //丑数 就是只包含质因数 2、3 和 5 的正整数。
    public class _263_IsUgly
    {
        public bool IsUgly(int n)
        {
            if (n < 1)
            {
                return false;
            }
            while (n % 5 == 0)
            {
                n /= 5;
            }
            while (n % 3 == 0)
            {
                n /= 3;
            }
            while (n % 2 == 0)
            {
                n /= 2;
            }
            return n == 1;
        }
    }
}
