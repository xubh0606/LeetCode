using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _28_StrStr
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (IsSame(haystack, i, needle))
                {
                    return i;
                }
            }
            return -1;
        }
        bool IsSame(string haystack, int start, string needle)
        {
            for (int i = 0; i < needle.Length; i++)
            {
                if (haystack[start] == needle[i])
                {
                    start++;
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
