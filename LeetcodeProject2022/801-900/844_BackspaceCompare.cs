using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _844_BackspaceCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            int indexS = s.Length - 1;
            int indexT = t.Length - 1;
            int saveS = 0;
            int saveT = 0;
            while (true)
            {
                if (indexS >= 0 && s[indexS] == '#')
                {
                    saveS++;
                    indexS--;
                    while (indexS >= 0 && (saveS > 0 || s[indexS] == '#'))
                    {
                        if (s[indexS] == '#')
                        {
                            saveS++;
                            indexS--;
                        }
                        else
                        {
                            saveS--;
                            indexS--;
                        }
                    }
                }
                if (indexT >= 0 && t[indexT] == '#')
                {
                    saveT++;
                    indexT--;
                    while (indexT >= 0 && (saveT > 0 || t[indexT] == '#'))
                    {
                        if (t[indexT] == '#')
                        {
                            saveT++;
                            indexT--;
                        }
                        else
                        {
                            saveT--;
                            indexT--;
                        }
                    }
                }
                if (indexS < 0 && indexT < 0)
                {
                    return true;
                }
                if (indexT < 0 || indexS < 0)
                {
                    return false;
                }
                if (s[indexS] != t[indexT])
                {
                    return false;
                }
                indexT--;
                indexS--;
            }
            return true;
        }
    }
}
