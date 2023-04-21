using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1190_ReverseParentheses
    {
        int m_start;
        public string ReverseParentheses(string s)
        {
            m_start = 0;
            return new string(Reverse(s, false).ToArray());
        }
        IList<char> Reverse(string s, bool isInParenthese)
        {
            IList<char> list = new List<char>();
            while (Cheak(s, isInParenthese))
            {
                if (s[m_start] == '(')
                {
                    m_start++;
                    IList<char> listIn = Reverse(s, true);
                    for (int i = 0; i < listIn.Count; i++)
                    {
                        list.Add(listIn[i]);
                    }
                }
                else
                {
                    list.Add(s[m_start]);
                    m_start++;
                }
            }
            m_start++;
            int left = 0;
            int right = list.Count - 1;
            if (isInParenthese)
            {
                while (left < right)
                {
                    Swap(list, left, right);
                    left++;
                    right--;
                }
            }
            return list;
        }
        void Swap(IList<char> list, int a, int b)
        {
            char temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        bool Cheak(string s, bool isInParenthese)
        {
            if (isInParenthese)
            {
                return s[m_start] != ')';
            }
            else
            {
                return m_start < s.Length;
            }
        }
    }
}
