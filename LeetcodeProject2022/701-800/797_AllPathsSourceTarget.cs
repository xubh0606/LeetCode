using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _797_AllPathsSourceTarget
    {
        IList<IList<int>> m_res;
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            int n = graph.Length;
            m_res = new List<IList<int>>();
            bool[] havePath = new bool[n];
            havePath[n - 1] = true;
            bool[] visited = new bool[n];
            if (dfs(havePath, visited, graph, 0, n - 1))
            {
                TraceBack(havePath, graph, 0, new List<int>(), n - 1);
            }
            return m_res;
        }

        bool dfs(bool[] havePath, bool[] visited, int[][] graph, int start, int target)
        {
            if (havePath[start])
            {
                return true;
            }
            if (visited[start])
            {
                return false;
            }
            visited[start] = true;
            for (int i = 0; i < graph[start].Length; i++)
            {
                if (graph[start][i] == target || dfs(havePath, visited, graph, graph[start][i], target))
                {
                    havePath[start] = true;
                }
            }
            return havePath[start];
        }

        void TraceBack(bool[] havePath, int[][] graph, int start, IList<int> list, int target)
        {
            list.Add(start);
            for (int i = 0; i < graph[start].Length; i++)
            {
                if (havePath[graph[start][i]])
                {
                    IList<int> new_list = new List<int>(list);
                    if (graph[start][i] == target)
                    {
                        new_list.Add(target);
                        m_res.Add(new_list);
                    }
                    else
                    {
                        TraceBack(havePath, graph, graph[start][i], new_list, target);
                    }
                }
            }
        }
    }
}
