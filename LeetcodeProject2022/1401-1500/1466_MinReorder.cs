using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1466_MinReorder
    {
        IList<IList<int>> m_numList;
        IList<IList<int>> m_connectionsList;
        int m_count;
        public int MinReorder(int n, int[][] connections)
        {
            m_count = 0;
            m_numList = new List<IList<int>>();
            m_connectionsList = new List<IList<int>>();
            for (int i = 0; i < n; i++)
            {
                m_numList.Add(new List<int>());
                m_connectionsList.Add(new List<int>());
            }
            for (int i = 0; i < connections.Length; i++)
            {
                int a = connections[i][0];
                int b = connections[i][1];
                m_numList[a].Add(b);
                m_numList[b].Add(a);
                m_connectionsList[a].Add(b);
                m_connectionsList[b].Add(b);
            }
            Dfs(-1, 0, connections);
            return m_count;
        }
        void Dfs(int father, int start, int[][] connections)
        {
            IList<int> n_list = m_numList[start];
            IList<int> c_list = m_connectionsList[start];
            for (int i = 0; i < n_list.Count; i++)
            {
                if (n_list[i] == father)
                {
                    continue;
                }
                if (c_list[i] != start)
                {
                    m_count++;
                }
                Dfs(start, n_list[i], connections);
            }
        }
    }
}
