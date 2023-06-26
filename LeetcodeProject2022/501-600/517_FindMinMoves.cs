using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _517_FindMinMoves
    {
        public int FindMinMoves(int[] machines)
        {
            int sum = 0;
            int len = machines.Length;
            for (int i = 0; i < len; i++)
            {
                sum += machines[i];
            }
            if (sum % len != 0)
            {
                return -1;
            }
            int avr = sum / len;
            //对超出的或者不足的进行流动，每次遍历整个数字并统计步数，
            //由于每次移动时必然需要中间介质的传导，所有的同类可以合并讨论形成累加统计
            //此时没考虑到同时产生移动的情况
            int carry = 0;
            int max = 0;
            for (int i = 0; i < len; i++)
            {
                carry = carry + avr - machines[i];
                max = Math.Max(max, Math.Abs(carry));
                max = Math.Max(max, machines[i] - avr);
            }
            return max;
        }
    }
}
