using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _49_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();
            IList<int[]> charCount = new List<int[]>();
            for (int i = 0; i < strs.Length; i++)
            {
                int[] cur_chars = GetCharCount(strs[i]);
                Insert(strs[i], cur_chars, charCount, res);
            }
            return res;
        }
        bool CheakAnagram(int[] charsA, int[] charsB)
        {
            for (int i = 0; i < 26; i++)
            {
                if (charsA[i] != charsB[i])
                {
                    return false;
                }
            }
            return true;
        }
        void Insert(string s, int[] cur_chars, IList<int[]> charCount, IList<IList<string>> res)
        {
            bool notChanged = true;
            for (int i = 0; i < charCount.Count; i++)
            {
                if (CheakAnagram(cur_chars, charCount[i]))
                {
                    res[i].Add(s);
                    notChanged = false;
                    break;
                }
            }
            if (notChanged)
            {
                charCount.Add(cur_chars);
                res.Add(new List<string>());
                res[res.Count - 1].Add(s);
            }
        }
        int[] GetCharCount(string s)
        {
            int[] cur_chars = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                cur_chars[s[i] - 'a']++;
            }
            return cur_chars;
        }
    }
}
