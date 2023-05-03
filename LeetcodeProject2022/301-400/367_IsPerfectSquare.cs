using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _367_IsPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            
            int left = 1;
            int right = 46341;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (mid * mid == num)
                {
                    return true;
                }
                if (mid * mid < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (left * left == num || right * right == num)
            {
                return true;
            }
            return false;
        }
    }
}
