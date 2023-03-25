using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _202_IsHappy
    {
        public bool IsHappy(int n)
        {
            int fast = n;
            int slow = n;
            do
            {
                if (slow == 1)
                {
                    return true;
                }
                slow = BitSquareSum(slow);
                fast = BitSquareSum(fast);
                fast = BitSquareSum(fast);
            }
            while (fast != slow);
            return slow == 1;
        }
        int BitSquareSum(int n)
        {
            int temp = 0;
            while (n > 0)
            {
                int num = n % 10;
                temp += num * num;
                n /= 10;
            }
            return temp;
        }
    }
}
