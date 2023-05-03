using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _392_IsSubsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            int j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (t[j] == s[i])
                {
                    j++;
                    i++;
                }
                else
                {
                    j++;
                }
                if ((s.Length - i) > (t.Length - j))
                {
                    return false;
                }
            }
            if (i == s.Length)
            {
                return true;
            }
            return false;
        }
    }
}
