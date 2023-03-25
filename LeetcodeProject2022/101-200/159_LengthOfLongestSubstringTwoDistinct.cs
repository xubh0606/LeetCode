using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _159_LengthOfLongestSubstringTwoDistinct
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            char[] t = new char[] { '0', '0' };
            bool changed = false;
            int maxCount = 1;
            int count = 0;
            int changeIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char cur = s[i];
                if (changed == false || t[0] == cur || t[1] == cur)
                {
                    if (t[0] == '0')
                    {
                        t[0] = cur;
                    }
                    else if (t[1] == '0' && cur != t[0])
                    {
                        t[1] = cur;
                        changed = true;
                    }
                    if (changed == true && s[i - 1] != cur)
                    {
                        changeIndex = i;
                    }
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = i - changeIndex + 1;
                    changeIndex = i;
                    if (t[0] == s[i - 1])
                    {
                        t[1] = cur;
                    }
                    else
                    {
                        t[0] = cur;
                    }
                }
            }
            if (count > maxCount)
            {
                return count;
            }
            return maxCount;
        }
    }
}
