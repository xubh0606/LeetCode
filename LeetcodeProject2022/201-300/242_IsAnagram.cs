using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _242_IsAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                int p = s[i] - '0';
                if (dic.ContainsKey(p))
                {
                    dic[p]++;
                }
                else
                {
                    dic.Add(p, 1);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                int p = t[i] - '0';
                if (dic.ContainsKey(p))
                {
                    dic[p]--;
                    if (dic[p] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
