using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _809_ExpressiveWords
    {
        IList<char> m_target;
        IList<int> m_lenList;
        public int ExpressiveWords(string s, string[] words)
        {
            int res = 0;
            GetList(s);
            for (int i = 0; i < words.Length; i++)
            {
                if (CanChangeTo(words[i]))
                {
                    res++;
                }
            }
            return res;
        }
        void GetList(string s)
        {
            m_target = new List<char>();
            m_lenList = new List<int>();
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                    continue;
                }
                m_lenList.Add(count);
                m_target.Add(s[i - 1]);
                count = 1;
            }
            m_lenList.Add(count);
            m_target.Add(s[s.Length - 1]);
        }
        bool CanChangeTo(string word)
        {
            int index = 0;
            int count = 1;
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                {
                    count++;
                    continue;
                }
                if (index >= m_lenList.Count)
                {
                    return false;
                }
                if (word[i - 1] != m_target[index])
                {
                    return false;
                }
                if (count != m_lenList[index])
                {
                    if (count > m_lenList[index])
                    {
                        return false;
                    }
                    if (m_lenList[index] == 2)
                    {
                        return false;
                    }
                }
                count = 1;
                index++;
            }
            if (index >= m_lenList.Count)
            {
                return false;
            }
            if (word[word.Length - 1] != m_target[index])
            {
                return false;
            }
            if (count != m_lenList[index])
            {
                if (count > m_lenList[index])
                {
                    return false;
                }
                if (m_lenList[index] == 2)
                {
                    return false;
                }
            }
            if (index < m_lenList.Count - 1)
            {
                return false;
            }
            return true;
        }
    }
}
