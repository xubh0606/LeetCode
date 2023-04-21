using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1048_LongestStrChain
    {
        public int LongestStrChain(string[] words)
        {
            Dictionary<string, int> strChainSet = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                strChainSet.TryAdd(words[i], 0);
            }
            int max = 0;
            Array.Sort(words, (a, b) => b.Length - a.Length);
            for (int i = 0; i < words.Length; i++)
            {
                if (max > words[i].Length)
                {
                    break;
                }
                if (strChainSet[words[i]] == 0)
                {
                    max = Math.Max(max, Dfs(words[i], strChainSet));
                }
            }
            return max;
        }
        int Dfs(string word, Dictionary<string, int> strChainSet)
        {
            int max = 1;
            for (int i = 0; i < word.Length; i++)
            {
                string cur_word = word.Remove(i, 1);
                if (strChainSet.ContainsKey(cur_word))
                {
                    if (strChainSet[cur_word] == 0)
                    {
                        max = Math.Max(max, Dfs(cur_word, strChainSet) + 1);
                    }
                    else
                    {
                        max = Math.Max(max, strChainSet[cur_word] + 1);
                    }
                }
            }
            strChainSet[word] = max;
            return max;
        }
    }
}
