using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _551_CheckRecord
    {
        public bool CheckRecord(string s)
        {
            int l = 0;
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    l++;
                    if (l == 3)
                    {
                        return false;
                    }
                }
                else
                {
                    l = 0;
                    if (s[i] == 'A')
                    {
                        a++;
                        if (a == 2)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
