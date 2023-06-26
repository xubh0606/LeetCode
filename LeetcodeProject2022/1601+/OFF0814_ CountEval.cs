using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class OFF0814_CountEval
    {
        public int CountEval(string s, int result)
        {
            //定义dp1[i,j]为括号从i到j的所有结果为1方法数，dp2则是结果为0
            int n = s.Length / 2 + 2;
            int[] dp1 = new int[n];
            int[] dp0 = new int[n];
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    bool b2 = GetBoolBetween(i * 2 - 2, j * 2, s);
                    if (j == 0)
                    {
                        if (b2)
                        {
                            dp1[i] = 1;
                        }
                        else
                        {
                            dp0[i] = 1;
                        }
                    }
                    else
                    {
                        if (s[j * 2 - 1] == '^')
                        {
                            if (b2)
                            {
                                dp1[i] += dp0[j];
                                dp0[i] += dp1[j];
                            }
                            else
                            {
                                dp1[i] += dp1[j];
                                dp0[i] += dp0[j];
                            }
                        }
                        else if (s[j * 2 - 1] == '&')
                        {
                            if (b2)
                            {
                                dp1[i] += dp1[j];
                                dp0[i] += dp0[j];
                            }
                            else
                            {
                                dp0[i] += dp1[j] + dp0[j];
                            }
                        }
                        else
                        {
                            if (b2)
                            {
                                dp1[i] += dp1[j] + dp0[j];
                            }
                            else
                            {
                                dp1[i] += dp1[j];
                                dp0[i] += dp0[j];
                            }
                        }
                    }
                }
            }
            if (result == 1)
            {
                return dp1[n - 1];
            }
            return dp0[n - 1];
        }
        bool GetBoolBetween(int end, int start, string s)
        {
            bool b = s[start] == '1';
            start += 2;
            while (start <= end)
            {
                char c = s[start - 1];
                bool b2 = s[start] == '1';
                if (c == '^')
                {
                    b = !(b2 == b);
                }
                else if (c == '&')
                {
                    b = b && b2;
                }
                else
                {
                    b = b || b2;
                }
                start += 2;
            }
            return b;
        }
    }
}
