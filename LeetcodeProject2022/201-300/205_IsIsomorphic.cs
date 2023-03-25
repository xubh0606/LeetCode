using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _205_IsIsomorphic
    {
        public bool IsIsomorphic(string s, string t)
        {
            int n = s.Length;
            Dictionary<char, char> dic1 = new Dictionary<char, char>();
            Dictionary<char, char> dic2 = new Dictionary<char, char>();
            for (int i = 0; i < n; i++)
            {
                char j = s[i];
                char k = t[i];
                if (dic1.ContainsKey(j) || dic2.ContainsKey(k))
                {
                    if (dic1.ContainsKey(j) && dic2.ContainsKey(k))
                    {
                        if (k != dic1[j] || dic2[k] != j)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    dic1.Add(j, k);
                    dic2.Add(k, j);
                }
            }
            return true;
        }
    }
}
