using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _886_PossibleBipartition
    {
        Dictionary<int, IList<int>> dislikeDic = new Dictionary<int, IList<int>>();
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            HashSet<int> group1 = new HashSet<int>();
            HashSet<int> group2 = new HashSet<int>();
            for (int i = 0; i < dislikes.Length; i++)
            {
                int a = dislikes[i][0];
                int b = dislikes[i][1];
                if (!dislikeDic.ContainsKey(a))
                {
                    dislikeDic.Add(a, new List<int>());
                }
                if (!dislikeDic.ContainsKey(b))
                {
                    dislikeDic.Add(b, new List<int>());
                }
                dislikeDic[a].Add(b);
                dislikeDic[b].Add(a);
            }
            for (int i = 0; i < n; i++)
            {
                if ((!dislikeDic.ContainsKey(i)) || group1.Contains(i) || group2.Contains(i))
                {
                    continue;
                }
                group1.Add(i);
                if (!FindGroup(i, group1, group2))
                {
                    return false;
                }
            }
            return true;
        }
        bool FindGroup(int cur, HashSet<int> group1, HashSet<int> group2)
        {
            IList<int> list = dislikeDic[cur];
            for (int i = 0; i < list.Count; i++)
            {
                int temp = list[i];
                if (group1.Contains(temp))
                {
                    return false;
                }
                else
                {
                    if (!group2.Contains(temp))
                    {
                        group2.Add(temp);
                        if (!FindGroup(temp, group2, group1))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
