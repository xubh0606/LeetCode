using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _344_ReverseString
    {
        public void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                Swap(s, i, s.Length - i - 1);
            }
        }
        void Swap(char[] s, int a, int b)
        {
            char temp = s[a];
            s[a] = s[b];
            s[b] = temp;
        }
    }
}
