using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    //无向图中连通分量的数目
    public class _323_CountComponents
    {
        int m_count;
        public int CountComponents(int n, int[][] edges)
        {
            int[] nodes = new int[n];
            m_count = n;
            for (int k = 0; k < n; k++)
            {
                nodes[k] = k;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                if (FindHead(edges[i][0], nodes) != FindHead(edges[i][1], nodes))
                {
                    Union(edges[i][0], edges[i][1], nodes);
                }
            }
            return m_count;
        }
        void Union(int i, int j, int[] nodes)
        {
            nodes[FindHead(i, nodes)] = FindHead(j, nodes);
            m_count--;
        }

        int FindHead(int i, int[] nodes)
        {
            if (nodes[i] != i)
            {
                return nodes[i] = FindHead(nodes[i], nodes);
            }
            return i;
        }
    }
}
