using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _371_GetSum
    {
        public int GetSum(int a, int b)
        {
            //给你两个整数 a 和 b ，不使用 运算符 + 和 - ​​​​​​​，计算并返回两整数之和。
            while (a != 0)
            {
                int temp = a ^ b;
                a = (a & b) << 1;
                b = temp;
            }
            return b;
        }
    }
}
