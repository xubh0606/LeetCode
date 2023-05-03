using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _326_PowerOfThree
    {
        public bool PowerOfThree(int n)
        {
            return n > 0 && 1162261467 % n == 0;
        }
        //public bool IsPowerOfThree(int n)
        //{
        //    if (n == int.MinValue || n == 0)
        //    {
        //        return false;
        //    }
        //    if (n < 0)
        //    {
        //        return false;
        //    }
        //    while (n != 1)
        //    {
        //        if (n % 3 != 0)
        //        {
        //            return false;
        //        }
        //        n /= 3;
        //    }
        //    return true;
        //}
    }
}
