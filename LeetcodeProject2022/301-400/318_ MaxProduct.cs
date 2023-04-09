using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _318__MaxProduct
    {
        //给你一个字符串数组 words ，找出并返回 length(words[i]) * length(words[j]) 的最大值，
        //并且这两个单词不含有公共字母。如果不存在这样的两个单词，返回 0 。
        public int MaxProduct(string[] words)
        {
            int maxLen = 0;
            int res = 0;
            Dictionary<int, IList<string>> len_words = new Dictionary<int, IList<string>>();
            for (int i = 0; i < words.Length; i++)
            {
                int cur_len = words[i].Length;
                if (len_words.ContainsKey(cur_len))
                {
                    len_words[cur_len].Add(words[i]);
                }
                else
                {
                    if (maxLen < cur_len)
                    {
                        maxLen = cur_len;
                    }
                    len_words.Add(cur_len, new List<string>());
                    len_words[cur_len].Add(words[i]);
                }
            }
            for (int i = maxLen; i > 0; i--)
            {
                if (len_words.ContainsKey(i))
                {
                    IList<string> list1 = len_words[i];
                    for (int j = i; j > 0; j--)
                    {
                        if (i * j < res)
                        {
                            continue;
                        }
                        if (len_words.ContainsKey(j))
                        {
                            IList<string> list2 = len_words[j];
                            if (AnyNoSimilar(list1, list2))
                            {
                                res = i * j;
                            }
                        }
                    }
                }
            }
            return res;
        }
        bool AnyNoSimilar(IList<string> list1, IList<string> list2)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                string word1 = list1[i];
                for (int j = 0; j < list2.Count; j++)
                {
                    string word2 = list2[j];
                    if (NoSimilar(word1, word2))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool NoSimilar(string word1, string word2)
        {
            int[] letters = new int[26];
            for (int i = 0; i < word1.Length; i++)
            {
                letters[word1[i] - 'a']++;
            }
            for (int j = 0; j < word2.Length; j++)
            {
                if (letters[word2[j] - 'a'] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
