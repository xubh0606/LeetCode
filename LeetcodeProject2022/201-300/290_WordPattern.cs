using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _290_WordPattern
    {
        public bool WordPattern(string pattern, string s)
        {
            int n = s.Length;
            int m = pattern.Length;
            Dictionary<char, string> dic = new Dictionary<char, string>();
            Dictionary<string, char> dic2 = new Dictionary<string, char>();
            int count = 0;
            string temp = "";
            for (int i = 0; i < n; i++)
            {
                if (s[i] == ' ')
                {
                    char key = pattern[count];
                    count++;
                    if (dic.ContainsKey(key))
                    {
                        if (temp != dic[key])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (dic2.ContainsKey(temp))
                        {
                            return false;
                        }
                        dic.Add(key, temp);
                        dic2.Add(temp, key);
                    }
                    temp = "";
                }
                else
                {
                    temp += s[i];
                }
            }
            if (count == m - 1)
            {
                char key = pattern[count];
                if (dic.ContainsKey(key))
                {
                    if (temp == dic[key])
                    {
                        return true;
                    }
                }
                else
                {
                    if (dic2.ContainsKey(temp))
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
