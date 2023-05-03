using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _320_GenerateAbbreviations
    {
        int m_total;
        string m_word;
        public IList<string> GenerateAbbreviations(string word)
        {
            m_total = word.Length;
            m_word = word;
            IList<string> res = new List<string>();
            getAllPossible(new char[m_total], 0, res);
            return res;
        }
        void getAllPossible(char[] abbreviation, int count, IList<string> res)
        {
            if (count == m_total)
            {
                res.Add(translate(abbreviation));
                return;
            }
            abbreviation[count] = m_word[count];
            getAllPossible(abbreviation, count + 1, res);
            abbreviation[count] = '1';
            getAllPossible(abbreviation, count + 1, res);
        }
        string translate(char[] abbreviation)
        {
            string s = "";
            int len = 0;
            for (int i = 0; i < m_total; i++)
            {
                if (abbreviation[i] != '1')
                {
                    if (len != 0)
                    {
                        s += Convert.ToString(len);
                        len = 0;
                    }
                    s += abbreviation[i];
                }
                else
                {
                    len++;
                }
            }
            if (len != 0)
            {
                s += Convert.ToString(len);
            }
            return s;
        }
    }
}
