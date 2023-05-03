using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _201_RangeBitwiseAnd
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            while (left < right)
            {
                right &= right - 1;
            }
            return right;
        }
    }
}
