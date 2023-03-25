using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _139_WordBreak
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> words = new HashSet<string>();
            for (int i = 0; i < wordDict.Count; i++)
            {
                words.Add(wordDict[i]);
            }
            int n = s.Length;
            int[] pasedRes = new int[n];
            return TraceBack(s, 0, n, words, pasedRes);
        }
        bool TraceBack(string s, int count, int n, HashSet<string> words, int[] pasedRes)
        {
            if (pasedRes[count] == 1)
            {
                return false;
            }
            string word = "";
            for (int i = count; i < n; i++)
            {
                word += s[i];
                if (i == n - 1)
                {
                    if (words.Contains(word))
                    {
                        return true;
                    }
                    pasedRes[count] = 1;
                    return false;
                }
                else
                {
                    if (words.Contains(word))
                    {
                        if (TraceBack(s, i + 1, n, words, pasedRes))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
