using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _291_WordPatternMatch
    {
        public bool WordPatternMatch(string pattern, string s)
        {
            int n = s.Length;
            int m = pattern.Length;
            Dictionary<char, string> dic = new Dictionary<char, string>();
            Dictionary<string, char> dic2 = new Dictionary<string, char>();
            return TraceBack(s, pattern, dic, dic2, 0, 0, n, m);
        }
        bool TraceBack(string s, string pattern, Dictionary<char, string> dic, Dictionary<string, char> dic2, int indexN, int indexM, int n, int m)
        {
            string temp = "";
            char key = pattern[indexM];
            if (indexM == m - 1)
            {
                for (int i = indexN; i < n; i++)
                {
                    temp += s[i];
                }
                if (dic.ContainsKey(key))
                {
                    if (dic[key] == temp)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    if (indexN == n || dic2.ContainsKey(temp))
                    {
                        return false;
                    }
                    return true;
                }
            }
            if (dic.ContainsKey(key))
            {
                for (int i = indexN; i < n; i++)
                {
                    temp += s[i];
                    if (temp == dic[key])
                    {
                        if (TraceBack(s, pattern, dic, dic2, i + 1, indexM + 1, n, m))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            for (int i = indexN; i < n; i++)
            {
                temp += s[i];
                if (dic2.ContainsKey(temp))
                {
                    continue;
                }
                dic2.Add(temp, key);
                dic.Add(key, temp);
                if (TraceBack(s, pattern, dic, dic2, i + 1, indexM + 1, n, m))
                {
                    return true;
                }
                dic2.Remove(temp);
                dic.Remove(key);
            }
            return false;
        }
    }
}
