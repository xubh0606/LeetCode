using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _784_LetterCasePermutation
    {
        IList<string> res = new List<string>();
        public IList<string> LetterCasePermutation(string s)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            for (int i = 0; i < 26; i++)
            {
                char c = (char)('a' + i);
                char bigC = (char)('A' + i);
                dic.Add(c, bigC);
                dic.Add(bigC, c);
            }
            int n = s.Length;
            TraceBack(s, dic, 0, n, "");
            return res;
        }
        void TraceBack(string s, Dictionary<char, char> dic, int count, int n, string str)
        {
            if (count == n)
            {
                res.Add(str);
                return;
            }
            char c = s[count];
            if (dic.ContainsKey(c))
            {
                TraceBack(s, dic, count + 1, n, str + c);
                TraceBack(s, dic, count + 1, n, str + dic[c]);
            }
            else
            {
                TraceBack(s, dic, count + 1, n, str + c);
            }
        }
    }
}
