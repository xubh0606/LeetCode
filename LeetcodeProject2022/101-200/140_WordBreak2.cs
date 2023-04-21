using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _140_WordBreak2
    {
        IList<string> res = new List<string>();
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> set = new HashSet<string>();
            int n = s.Length;
            for (int i = 0; i < wordDict.Count; i++)
            {
                set.Add(wordDict[i]);
            }
            TraceBack(s, n, 0, set, "");
            return res;
        }
        void TraceBack(string s, int n, int index, HashSet<string> set, string breakedStr)
        {
            if (index == n)
            {
                res.Add(breakedStr);
                return;
            }
            string temp = "";
            string save = breakedStr;
            for (int i = 0; i < 10 && (i + index) < n; i++)
            {
                temp += s[i + index];
                if (set.Contains(temp))
                {
                    if (index == 0)
                    {
                        breakedStr = breakedStr + temp;
                        TraceBack(s, n, index + 1 + i, set, breakedStr);
                        breakedStr = save;
                    }
                    else
                    {
                        breakedStr = breakedStr + " " + temp;
                        TraceBack(s, n, index + 1 + i, set, breakedStr);
                        breakedStr = save;
                    }
                }
            }
        }
    }
}
