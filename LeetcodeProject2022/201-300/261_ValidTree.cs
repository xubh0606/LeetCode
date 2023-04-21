using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _261_ValidTree
    {
        public bool ValidTree(int n, int[][] edges)
        {
            if (edges.Length < n - 1)
            {
                return false;
            }
            int[] nodes = new int[n];
            for (int j = 1; j < n; j++)
            {
                nodes[j] = j;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                int a = findHead(edges[i][0], nodes);
                int b = findHead(edges[i][1], nodes);
                if (a != b)
                {
                    unit(edges[i][0], edges[i][1], nodes);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        void unit(int i, int j, int[] nodes)
        {
            nodes[findHead(i, nodes)] = findHead(j, nodes);
        }

        int findHead(int i, int[] nodes)
        {
            if (nodes[i] != i)
            {
                nodes[i] = findHead(nodes[i], nodes);
                return nodes[i];
            }
            return i;
        }
    }
}
