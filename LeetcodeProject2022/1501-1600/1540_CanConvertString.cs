using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1540_CanConvertString
    {
        public bool CanConvertString(string s, string t, int k)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] moveTimes = new int[26];
            //每次增加一，如果落在相同位置意味着需要进入多轮才能完成。最后比较k的大小即可
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    moveTimes[CountMovement(s[i], t[i])]++;
                }
            }
            int max = 0;
            int extra = 0;
            for (int i = 0; i < 26; i++)
            {
                if (moveTimes[i] >= max)
                {
                    max = moveTimes[i];
                    extra = i;
                }
            }
            return k >= (max - 1) * 26 + extra;
        }
        int CountMovement(char c1, char c2)
        {
            return (c2 - c1 + 26) % 26;
        }
    }
}
