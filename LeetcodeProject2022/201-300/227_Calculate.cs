using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _227_Calculate
    {
        int m_cur;
        int m_index;
        bool m_isMul;
        public int Calculate(string s)
        {
            m_cur = 0;
            m_index = 0;
            m_isMul = true;
            while (s[m_index] == ' ')
            {
                m_index++;
                continue;
            }
            m_cur += NextSum(s);
            while (m_index < s.Length)
            {
                if (s[m_index] == ' ')
                {
                    m_index++;
                    continue;
                }
                if (s[m_index] == '-')
                {
                    m_index++;
                    while (s[m_index] == ' ')
                    {
                        m_index++;
                        continue;
                    }
                    m_cur -= NextSum(s);
                }
                else
                {
                    m_index++;
                    while (s[m_index] == ' ')
                    {
                        m_index++;
                        continue;
                    }
                    m_cur += NextSum(s);
                }
            }
            return m_cur;
        }
        //在加减法出现之前一直进行计算
        int NextSum(string s)
        {
            int num = GetNum(s);
            while (m_index < s.Length && s[m_index] != '-' && s[m_index] != '+')
            {
                m_index++;
                if (m_isMul)
                {
                    while (s[m_index] == ' ')
                    {
                        m_index++;
                        continue;
                    }
                    num *= GetNum(s);
                }
                else
                {
                    while (s[m_index] == ' ')
                    {
                        m_index++;
                        continue;
                    }
                    num /= GetNum(s);
                }
            }
            while (m_index < s.Length && s[m_index] == ' ')
            {
                m_index++;
                continue;
            }
            return num;
        }
        int GetNum(string s)
        {
            if (m_index == s.Length)
            {
                return 1;
            }
            int num = s[m_index] - '0';
            m_index++;
            while (m_index < s.Length)
            {
                char c = s[m_index];
                if (c == '-' || c == '+' || c == '*' || c == '/' || c == ' ')
                {
                    break;
                }
                num = num * 10 + c - '0';
                m_index++;
            }
            while (m_index < s.Length && s[m_index] == ' ')
            {
                m_index++;
                continue;
            }
            if (m_index < s.Length && s[m_index] == '/')
            {
                m_isMul = false;
            }
            else
            {
                m_isMul = true;
            }
            return num;
        }
    }
}
