using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _785_IsBipartite
    {
        bool isNotB = false;
        public bool IsBipartite(int[][] graph)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            for (int i = 0; i < graph.Length; i++)
            {
                if (!(set1.Contains(i) || set2.Contains(i)))
                {
                    set1.Add(i);
                    dfs(set1, set2, i, graph, true);
                    if (isNotB)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        void dfs(HashSet<int> set1, HashSet<int> set2, int index, int[][] graph, bool inFirstSet)
        {
            for (int i = 0; i < graph[index].Length; i++)
            {
                int point = graph[index][i];
                if (inFirstSet)
                {
                    if (set1.Contains(point))
                    {
                        isNotB = true;
                        return;
                    }
                    if (!set2.Contains(point))
                    {
                        set2.Add(point);
                        dfs(set1, set2, point, graph, false);
                    }
                }
                else
                {
                    if (set2.Contains(point))
                    {
                        isNotB = true;
                        return;
                    }
                    if (!set1.Contains(point))
                    {
                        set1.Add(point);
                        dfs(set1, set2, point, graph, true);
                    }
                }
            }
        }
    }
}
