using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _288_ValidWordAbbr
    {
        Dictionary<string, IList<string>> m_dic;
        public _288_ValidWordAbbr(string[] dictionary)
        {
            m_dic = new Dictionary<string, IList<string>>();
            for (int i = 0; i < dictionary.Length; i++)
            {
                string s = dictionary[i];
                string validStr = GetValidWord(s);
                if (m_dic.ContainsKey(validStr))
                {
                    m_dic[validStr].Add(s);
                }
                else
                {
                    IList<string> list = new List<string>();
                    list.Add(s);
                    m_dic.Add(validStr, list);
                }
            }
        }

        public bool IsUnique(string word)
        {
            string validStr = GetValidWord(word);
            if (m_dic.ContainsKey(validStr))
            {
                IList<string> list = m_dic[validStr];
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != word)
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }

        string GetValidWord(string s)
        {
            if (s.Length < 3)
            {
                return s;
            }
            return $"{s[0]}{s.Length - 2}{s[s.Length - 1]}";
        }
    }

    /**
     * Your ValidWordAbbr object will be instantiated and called as such:
     * ValidWordAbbr obj = new ValidWordAbbr(dictionary);
     * bool param_1 = obj.IsUnique(word);
     */
}
