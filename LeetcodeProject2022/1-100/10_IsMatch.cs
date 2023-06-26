using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _10_IsMatch
    {
        int m_lenS;
        int m_lenP;
        public bool IsMatch(string s, string p)
        {
            //每次提取p 中元素，如果带*则多次匹配，否则单次匹配
            m_lenS = s.Length;
            m_lenP = p.Length;
            return CheakMatch(s, p, 0, 0);
        }
        bool CheakMatch(string s, string p, int leftS, int leftP)
        {
            while (leftP < m_lenP && leftS < m_lenS)
            {
                if (leftP == m_lenP - 1 || p[leftP + 1] != '*')
                {
                    if (s[leftS] == p[leftP] || p[leftP] == '.')
                    {
                        leftP++;
                        leftS++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    break;
                }
            }
            //判断是否p走到头
            if (leftP == m_lenP)
            {
                if (leftS == m_lenS)
                {
                    return true;
                }
                return false;
            }
            if (leftS == m_lenS)
            {
                return CheakEnd(p, leftP + 1);
            }
            //此时因为带* ，需要进入中间判断
            return CheakMatchMid(s, p, p[leftP], leftS, leftP + 2);
        }
        bool CheakEnd(string p, int leftP)
        {
            if (leftP >= m_lenP || p[leftP] != '*')
            {
                return false;
            }
            leftP += 2;
            while (leftP < m_lenP)
            {
                if (p[leftP] != '*')
                {
                    return false;
                }
                leftP += 2;
            }
            return leftP == m_lenP + 1;
        }
        bool CheakMatchMid(string s, string p, char c, int leftS, int leftP)
        {
            while (leftS <= m_lenS || c == '.')
            {
                if (CheakMatch(s, p, leftS, leftP))
                {
                    return true;
                }
                if (leftS < m_lenS && (s[leftS] == c || c == '.'))
                {
                    leftS++;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
