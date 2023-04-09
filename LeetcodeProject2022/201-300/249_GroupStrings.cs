using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _249_GroupStrings
    {
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            IList<IList<string>> res = new List<IList<string>>();
            int count = -1;
            for (int i = 0; i < strings.Length; i++)
            {
                bool notContainsSame = true;
                string s = strings[i];
                for (int j = 0; j < res.Count; j++)
                {
                    if (CanShiftedTo(res[j][0], s))
                    {
                        res[j].Add(s);
                        notContainsSame = false;
                        break;
                    }
                }
                if (notContainsSame)
                {
                    res.Add(new List<string>());
                    count++;
                    res[count].Add(s);
                }
            }
            return res;
        }
        bool CanShiftedTo(string target, string s)
        {
            if (target.Length != s.Length || s.Length == 0)
            {
                return false;
            }
            int shiftCount = GetShiftCount(s[0], target[0]);
            for (int i = 1; i < s.Length; i++)
            {
                int toZ = s[i] + shiftCount - 'z';
                if (toZ > 0)
                {
                    char temp = (char)('a' + toZ - 1);
                    if (temp != target[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (target[i] != s[i] + shiftCount)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        int GetShiftCount(char s0, char t0)
        {
            int count = 0;
            while (s0 != t0)
            {
                if (s0 == 'z')
                {
                    s0 = 'a';
                }
                else
                {
                    s0++;
                }
                count++;
            }
            return count;
        }
    }
}
