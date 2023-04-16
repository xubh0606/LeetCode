using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _839_NumSimilarGroups
    {
        public int NumSimilarGroups(string[] strs)
        {
            Dictionary<int, int> dicS = new Dictionary<int, int>();
            Dictionary<int, IList<int>> dicL = new Dictionary<int, IList<int>>();
            int n = strs.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool notMatchd = true;
                for (int j = 0; j < count; j++)
                {
                    if (dicL.ContainsKey(j))
                    {
                        IList<int> list = dicL[j];
                        for (int k = 0; k < list.Count; k++)
                        {
                            if (AreSimilar(strs[list[k]], strs[i]))
                            {
                                if (notMatchd)
                                {
                                    notMatchd = false;
                                    dicS.Add(i, j);
                                    list.Add(i);
                                    break;
                                }
                                else
                                {
                                    int cur = dicS[i];
                                    AddTo(dicL, cur, list, dicS, j);
                                    dicL.Remove(cur);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                if (notMatchd)
                {
                    dicL.Add(count, new List<int>());
                    dicL[count].Add(i);
                    count++;
                }
            }
            return dicL.Count;
        }

        void AddTo(Dictionary<int, IList<int>> dicL, int v, IList<int> list, Dictionary<int, int> dicS, int w)
        {
            IList<int> l = dicL[v];
            for (int i = 0; i < l.Count; i++)
            {
                int cur = l[i];
                list.Add(cur);
                dicS[cur] = w;
            }
        }

        bool AreSimilar(string i, string j)
        {
            char temp1 = '0';
            char temp2 = '0';
            int count = 0;
            for (int k = 0; k < i.Length; k++)
            {
                if (i[k] != j[k])
                {
                    if (count == 0)
                    {
                        temp1 = i[k];
                        temp2 = j[k];
                        count++;
                    }
                    else if (count == 1)
                    {
                        if (temp1 != j[k] || temp2 != i[k])
                        {
                            return false;
                        }
                        count++;
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
