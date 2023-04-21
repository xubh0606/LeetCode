using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _854_KSimilarity
    {
        int m_minCount = int.MaxValue;
        string m_target;
        public int KSimilarity(string s1, string s2)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    sb1.Append(s1[i]);
                    sb2.Append(s2[i]);
                }
            }
            m_target = sb2.ToString();
            char[] s3 = sb1.ToString().ToCharArray();
            traceBack(s3, 0, 0);
            return m_minCount;
        }
        void traceBack(char[] s1, int start, int count)
        {
            if (count >= m_minCount)
            {
                return;
            }
            if (start == s1.Length - 1)
            {
                m_minCount = count;
                return;
            }
            for (int i = start; i < s1.Length; i++)
            {
                if (s1[i] != m_target[i])
                {
                    for (int j = i + 1; j < s1.Length; j++)
                    {
                        if (s1[j] == m_target[i] && m_target[j] != s1[j])
                        {
                            char temp = s1[i];
                            s1[i] = s1[j];
                            s1[j] = temp;
                            traceBack(s1, i + 1, count + 1);
                            s1[j] = s1[i];
                            s1[i] = temp;
                            if (s1[i] == m_target[j]) break;
                        }
                    }
                }
            }
        }
    }
}
