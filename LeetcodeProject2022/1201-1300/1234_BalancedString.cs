using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300
{
    public class _1234_BalancedString
    {
     //问题的本质可以看做：将超出的字符数目通过截取变成小于等于 1/4 的最短截取长度
        int up = 1;
        int down = -1;
        public int BalancedString(string s)
        {
            int[] totalSum = new int[4];
            for (int i = 0; i < s.Length; i++)
            {
                Change(s[i], totalSum, up);
            }
            int min = int.MaxValue;
            int count = s.Length / 4;
            for (int i = 0; i < 4; i++)
            {
                if (totalSum[i] <= count)
                {
                    totalSum[i] = 0;
                }
                else
                {
                    totalSum[i] -= count;
                }
            }
            if (isBanlance(totalSum))
            {
                return 0;
            }
            int left = 0;
            int right = 0;
            while (right < s.Length)
            {
                Change(s[right], totalSum, down);
                right++;
                if (isBanlance(totalSum))
                {
                    while (isBanlance(totalSum))
                    {
                        Change(s[left], totalSum, up);
                        left++;
                    }
                    min = Math.Min(right - left + 1, min);
                }
            }
            return min;
        }
        bool isBanlance(int[] totalSum)
        {
            for (int i = 0; i < totalSum.Length; i++)
            {
                if (totalSum[i] > 0)
                {
                    return false;
                }
            }
            return true;
        }
        void Change(char c, int[] totalSum, int isUp)
        {
            if (c == 'Q')
            {
                totalSum[0] += isUp;
            }
            if (c == 'W')
            {
                totalSum[1] += isUp;
            }
            if (c == 'E')
            {
                totalSum[2] += isUp;
            }
            if (c == 'R')
            {
                totalSum[3] += isUp;
            }
        }
    }
}
