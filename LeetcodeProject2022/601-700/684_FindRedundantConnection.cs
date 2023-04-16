using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _684_FindRedundantConnection
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            int[] res = new int[2];
            int n = edges.Length;
            int[] node = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                node[i] = i;
            }
            for (int j = 0; j < n; j++)
            {
                if (findHead(node[edges[j][0]], node) == findHead(node[edges[j][1]], node))
                {
                    return edges[j];
                }
                unionHead(edges[j][0], edges[j][1], node);
            }
            return res;
        }
        int unionHead(int i, int j, int[] node)
        {
            if (node[i] != node[j])
            {
                node[findHead(j, node)] = findHead(i, node);
            }
            return node[j];
        }
        int findHead(int i, int[] node)
        {
            if (node[i] != i)
            {
                node[i] = findHead(node[i], node);
            }
            return node[i];
        }
    }
}
