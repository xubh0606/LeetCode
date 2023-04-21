using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _8_MyAtoi
    {
        public int MyAtoi(string s)
        {
            int i = 0;
            for (; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    break;
                }
            }
            bool isMinus;
            if (i >= s.Length)
            {
                return 0;
            }
            if (s[i] == '-')
            {
                isMinus = true;
                i++;
            }
            else
            {
                isMinus = false;
                if (s[i] == '+')
                {
                    i++;
                }
            }
            int num = 0;
            for (; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    break;
                }
                if (num > int.MaxValue / 10)
                {
                    return isMinus ? int.MinValue : int.MaxValue;
                }
                if (num == int.MaxValue / 10)
                {
                    if (isMinus)
                    {
                        if (s[i] > '8')
                        {
                            return int.MinValue;
                        }
                        if (s[i] == '8')
                        {
                            return int.MinValue;
                        }
                    }
                    if ((!isMinus) && s[i] > '7')
                    {
                        return int.MaxValue;
                    }
                }
                num = num * 10 + s[i] - '0';
            }
            return isMinus ? (-num) : num;
        }
    }
}
