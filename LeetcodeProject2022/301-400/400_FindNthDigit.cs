using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _400_FindNthDigit
    {
        public int FindNthDigit(int n)
        {
            int power = 1;
            while (power * Math.Pow( 10, power) <= n)
            {
                n += (int)Math.Pow(10, power);
                power++;
            }
            return (n / power).ToString()[n % power]-'0';
        }
    }
}
