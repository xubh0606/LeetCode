using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _418_WordsTyping
    {
        public int WordsTyping(string[] sentence, int rows, int cols)
        {
            int n = sentence.Length, ans = 0;
            int[] len = new int[n], next = new int[n];

            for (int i = 0; i < n; i++) { len[i] = sentence[i].Length + 1; }
            for (int i = 0; i < n; i++)
            {
                int index = i, c = 0, cnt = 0;
                for (; (c += len[index]) <= cols + 1; index = index + 1 < n ? index + 1 : ++cnt - cnt) ;
                next[i] = cnt * 100 + index;
            }

            for (int i = 0, index = 0; i < rows; i++, ans += next[index] / 100, index = next[index] % 100) ;
            return ans;

        }
    }
}
