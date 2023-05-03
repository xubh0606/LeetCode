using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1408_StringMatching
    {
        //一种有趣的思路是：建立公共父字符串，然后分析是否在其他范围内
        //当前思路：建立单词表，直接找头字母的表然后一一对应即可
        public IList<string> StringMatching(string[] words)
        {
            IList<int>[][] strWordsSet = new IList<int>[words.Length][];
            IList<string> res = new List<string>();
            HashSet<int> used = new HashSet<int>();
            for (int i = 1; i < words.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (used.Contains(i))
                    {
                        break;
                    }
                    if (used.Contains(j))
                    {
                        continue;
                    }
                    if (words[i].Length == words[j].Length)
                    {
                        if (used.Contains(i))
                        {
                            continue;
                        }
                        if (used.Contains(j))
                        {
                            continue;
                        }
                        if (CheakSame(words[i], words[j]))
                        {
                            res.Add(words[i]);
                            res.Add(words[j]);
                            used.Add(i);
                            used.Add(j);
                        }
                    }
                    if (words[i].Length < words[j].Length)
                    {
                        if (used.Contains(i))
                        {
                            continue;
                        }
                        if (strWordsSet[j] == null)
                        {
                            strWordsSet[j] = new IList<int>[26];
                            for (int k = 0; k < words[j].Length; k++)
                            {
                                char c = words[j][k];
                                if (strWordsSet[j][c - 'a'] == null)
                                {
                                    strWordsSet[j][c - 'a'] = new List<int>();
                                }
                                strWordsSet[j][c - 'a'].Add(k);
                            }
                        }
                        if (CheakContain(j, words[i], strWordsSet, words[j]))
                        {
                            res.Add(words[i]);
                            used.Add(i);
                        }
                    }
                    else
                    {
                        if (used.Contains(j))
                        {
                            continue;
                        }
                        if (strWordsSet[i] == null)
                        {
                            strWordsSet[i] = new IList<int>[26];
                            for (int k = 0; k < words[i].Length; k++)
                            {
                                char c = words[i][k];
                                if (strWordsSet[i][c - 'a'] == null)
                                {
                                    strWordsSet[i][c - 'a'] = new List<int>();
                                }
                                strWordsSet[i][c - 'a'].Add(k);
                            }
                        }
                        if (CheakContain(i, words[j], strWordsSet, words[i]))
                        {
                            res.Add(words[j]);
                            used.Add(j);
                        }
                    }
                }
            }
            return res;
        }
        bool CheakContain(int place, string word, IList<int>[][] strWordsSet, string wordTarget)
        {
            if (strWordsSet[place][word[0] - 'a'] == null)
            {
                return false;
            }
            IList<int> startList = strWordsSet[place][word[0] - 'a'];
            for (int i = 0; i < startList.Count; i++)
            {
                int start = startList[i];
                if (Cheak(start + 1, wordTarget, word))
                {
                    return true;
                }
            }
            return false;
        }
        bool Cheak(int start, string wordTarget, string word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (start < wordTarget.Length && wordTarget[start] == word[i])
                {
                    start++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        bool CheakSame(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
