using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _244_WordDistance
    {
        Dictionary<string, IList<int>> m_wordsDict;
        public _244_WordDistance(string[] wordsDict)
        {
            m_wordsDict = new Dictionary<string, IList<int>>();
            for (int i = 0; i < wordsDict.Length; i++)
            {
                string word = wordsDict[i];
                if (m_wordsDict.ContainsKey(word))
                {
                    m_wordsDict[word].Add(i);
                }
                else
                {
                    IList<int> list = new List<int>();
                    list.Add(i);
                    m_wordsDict.Add(word, list);
                }
            }
        }

        public int Shortest(string word1, string word2)
        {
            IList<int> list1 = m_wordsDict[word1];
            IList<int> list2 = m_wordsDict[word2];
            int i = 0;
            int j = 0;
            int min = int.MaxValue;
            while (i < list1.Count && j < list2.Count)
            {
                if (list2[j] > list1[i])
                {
                    min = Math.Min(min, list2[j] - list1[i]);
                    i++;
                }
                else
                {
                    min = Math.Min(min, list1[i] - list2[j]);
                    j++;
                }
            }
            return min;
        }
    }
}
/**
 * Your WordDistance object will be instantiated and called as such:
 * WordDistance obj = new WordDistance(wordsDict);
 * int param_1 = obj.Shortest(word1,word2);
 */
