using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _737_AreSentencesSimilarTwo
    {
        public bool AreSentencesSimilarTwo(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            int len1 = sentence1.Length;
            int len2 = sentence2.Length;
            if (len2 != len1)
            {
                return false;
            }
            if (len1 == 0)
            {
                return true;
            }
            int count = 0;
            Dictionary<int, IList<string>> dicList = new Dictionary<int, IList<string>>();
            Dictionary<string, int> dicStr = new Dictionary<string, int>();
            for (int i = 0; i < similarPairs.Count; i++)
            {
                string p1 = similarPairs[i][0];
                string p2 = similarPairs[i][1];
                if (dicStr.ContainsKey(p1) && dicStr.ContainsKey(p2))
                {
                    if (!(dicStr[p1] == dicStr[p2]))
                    {
                        int c2 = dicStr[p2];
                        int c1 = dicStr[p1];
                        for (int j = 0; j < dicList[c2].Count; j++)
                        {
                            string str = dicList[c2][j];
                            dicStr[str] = c1;
                            dicList[c1].Add(str);
                        }
                    }
                }
                else if (dicStr.ContainsKey(p1))
                {
                    int temp = dicStr[p1];
                    dicList[temp].Add(p2);
                    dicStr.Add(p2, temp);
                }
                else if (dicStr.ContainsKey(p2))
                {
                    int temp = dicStr[p2];
                    dicList[temp].Add(p1);
                    dicStr.Add(p1, temp);
                }
                else
                {
                    dicList.Add(count, new List<string>());
                    dicList[count].Add(p1);
                    dicStr.Add(p1, count);
                    if (p1 != p2)
                    {
                        dicList[count].Add(p2);
                        dicStr.Add(p2, count);
                    }
                    count++;
                }
            }
            for (int i = 0; i < sentence1.Length; i++)
            {
                if (dicStr.ContainsKey(sentence1[i]) && dicStr.ContainsKey(sentence2[i]))
                {
                    if (dicStr[sentence1[i]] != dicStr[sentence2[i]])
                    {
                        return false;
                    }
                }
                else
                {
                    if (sentence2[i] == sentence1[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
