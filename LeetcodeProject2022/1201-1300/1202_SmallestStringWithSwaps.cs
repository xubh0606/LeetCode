using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300
{
    public class _1202_SmallestStringWithSwaps
    {
        int m_count;
        IList<int> m_words;
        public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            m_words = new List<int>();
            Dictionary<int, int> samePairsSet = new Dictionary<int, int>();//key:string index,val head
            int[] head = new int[s.Length];
            for(int i = 0; i < head.Length; i++)
            {
                head[i] = i;
            }
            IList<int[]> wordsArrList = new List<int[]>();
            m_count = 0;
            char[] charArr = s.ToArray();
            for (int i = 0; i < pairs.Count; i++)
            {
                InsertSet(charArr, head, samePairsSet, wordsArrList, pairs[i][0], pairs[i][1]);
            }
            int[] count = new int[m_count];
            for (int i = 0; i < charArr.Length; i++)
            {
                int temp = FindHead(head, i);
                if (samePairsSet.ContainsKey(temp))
                {
                    int index = samePairsSet[temp];
                    while (wordsArrList[index][count[index]] == 0)
                    {
                        count[index]++;
                    }
                    charArr[i] = (char)(count[index] + 'a');
                    wordsArrList[index][count[index]]--;
                }
            }
            return new string(charArr);
        }

        void InsertSet(char[] charArr, int[] head, Dictionary<int, int> samePairsSet, IList<int[]> wordsArrList, int a, int b)
        {
            int ha = FindHead(head, a);
            int hb = FindHead(head, b);
            if (samePairsSet.ContainsKey(ha) && samePairsSet.ContainsKey(hb))
            {
                int insetA = samePairsSet[ha];
                int insetB = samePairsSet[hb];
                if (insetA != insetB)
                {
                    if (m_words[insetA] > m_words[insetB])
                    {
                        Union(insetA, insetB, wordsArrList);
                        head[hb] = ha;
                    }
                    else
                    {
                        Union(insetB, insetA, wordsArrList);
                        head[ha] = hb;
                    }
                }
            }
            else if (samePairsSet.ContainsKey(ha))
            {
                head[b] = ha;
                wordsArrList[samePairsSet[ha]][charArr[b] - 'a']++;
            }
            else if (samePairsSet.ContainsKey(hb))
            {
                head[a] = hb;
                wordsArrList[samePairsSet[hb]][charArr[a] - 'a']++;
            }
            else
            {
                wordsArrList.Add(new int[26]);
                wordsArrList[m_count][charArr[b] - 'a']++;
                if (a == b)
                {
                    m_words.Add(1);
                }
                else
                {
                    wordsArrList[m_count][charArr[a] - 'a']++;
                    m_words.Add(2);
                    head[b] = a;
                }
                samePairsSet.Add(a, m_count);
                m_count++;
            }
        }

        void Union(int a, int b, IList<int[]> wordsArrList)
        {
            for (int i = 0; i < 26; i++)
            {
                wordsArrList[a][i] += wordsArrList[b][i];
            }
            m_words[a] += m_words[b];
            m_words[b] = 0;
            wordsArrList[b] = null;
        }

        int FindHead(int[] head, int index)
        {
            if (head[index] != index)
            {
                head[index] = FindHead(head, head[index]);
                return head[index];
            }
            return index;
        }
    }
}
