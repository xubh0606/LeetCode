using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _87_IsScramble
    {
        string m_s;
        string m_t;
        bool[,,] m_saved;
        bool[,,] m_visited;
        public bool IsScramble(string s1, string s2)
        {
            m_s = s1;
            m_t = s2;
            m_saved = new bool[s1.Length, s1.Length + 1, s1.Length];
            m_visited = new bool[s1.Length, s1.Length + 1,  s1.Length];
            return Cheak(0, s1.Length, 0);
        }
        bool Cheak(int left1, int right1, int left2)
        {
            if (m_visited[left1, right1, left2])
            {
                return m_saved[left1, right1, left2];
            }
            //首先确认是否为相同字符串
            m_visited[left1, right1, left2] = true;
            if (IsSame(left1, right1, left2))
            {
                m_saved[left1, right1, left2] = true;
                return true;
            }
            //在判定扰乱情况
            for (int cutIndex = 1; cutIndex < right1 - left1; cutIndex++)
            {
                if (Cheak(left1, left1 + cutIndex, left2) && Cheak(left1 + cutIndex, right1, left2 + cutIndex))
                {
                    m_saved[left1, right1, left2] = true;
                    return true;
                }
                if (Cheak(left1, left1 + cutIndex, left2 + right1 - left1 - cutIndex) && Cheak(left1 + cutIndex, right1, left2))
                {
                    m_saved[left1, right1, left2] = true;
                    return true;
                }
            }
            return false;
        }
        bool IsSame(int left1, int right1, int left2)
        {
            for (; left1 < right1; left1++)
            {
                if (m_s[left1] != m_t[left2])
                {
                    return false;
                }
                left2++;
            }
            return true;
        }
    }
}
