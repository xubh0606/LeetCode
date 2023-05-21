using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _2000_ReversePrefix
    {
        public string ReversePrefix(string word, char ch)
        {
            string s = "";
            int i = 0;
            while (i < word.Length && word[i] != ch)
            {
                i++;
            }
            if (i == word.Length)
            {
                return word;
            }
            int j = i + 1;
            while (i >= 0)
            {
                s += word[i];
                i--;
            }
            s += word.Substring(j);
            return s;
        }
    }
}
