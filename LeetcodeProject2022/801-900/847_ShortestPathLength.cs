using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _847_ShortestPathLength
    {
        public int ShortestPathLength(int[][] graph)
        {
            int n = graph.Length;
            Queue<int[]> q = new Queue<int[]>();//node start, distance, state;
            bool[,] visited = new bool[n, 1 << n];
            for (int i = 0; i < n; i++)
            {
                q.Enqueue(new int[] { i, 0, 1 << i });
                visited[i, 1 << i] = true;
            }
            int end = (1 << n) - 1;
            while (q.Count > 0)
            {
                int c = q.Count;
                for (int i = 0; i < c; i++)
                {
                    int[] cur = q.Dequeue();
                    int start = cur[0];
                    int distance = cur[1];
                    int state = cur[2];
                    if (state == end)
                    {
                        return distance;
                    }
                    foreach (int x in graph[start])
                    {
                        int new_state = state | (1 << x);
                        if (!visited[x, new_state])
                        {
                            visited[x, new_state] = true;
                            q.Enqueue(new int[] { x, distance + 1, new_state });
                        }
                    }
                }
            }
            return 0;
        }
    }
}
