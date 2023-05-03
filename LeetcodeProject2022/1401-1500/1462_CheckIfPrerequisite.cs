using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1462_CheckIfPrerequisite
    {
        Dictionary<int, IList<int>> m_isPre;
        Dictionary<int, HashSet<int>> m_cheak;
        Dictionary<int, IList<int>> m_dfsList;
        public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
        {
            m_isPre = new Dictionary<int, IList<int>>();
            for (int i = 0; i < prerequisites.Length; i++)
            {
                int p1 = prerequisites[i][0];
                int p2 = prerequisites[i][1];
                if (!m_isPre.ContainsKey(p2))
                {
                    m_isPre.Add(p2, new List<int>());
                }
                m_isPre[p2].Add(p1);
            }
            bool[] res = new bool[queries.Length];
            m_dfsList = new Dictionary<int, IList<int>>();
            m_cheak = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < queries.Length; i++)
            {
                int start = queries[i][1];
                int target = queries[i][0];
                if (!m_cheak.ContainsKey(start))
                {
                    DfsFindPre(start);
                }
                res[i] = m_cheak[start].Contains(target);
            }
            return res;
        }

        IList<int> DfsFindPre(int start)
        {

            if (m_dfsList.ContainsKey(start))
            {
                return m_dfsList[start];
            }
            HashSet<int> set = new HashSet<int>();
            if (!m_isPre.ContainsKey(start))
            {
                m_dfsList.Add(start, new List<int>());
                m_cheak.Add(start, set);
                return m_dfsList[start];
            }
            IList<int> listPre = m_isPre[start];
            for (int i = 0; i < listPre.Count; i++)
            {
                int new_start = listPre[i];
                if (!set.Contains(new_start))
                {
                    set.Add(new_start);
                }
                IList<int> new_list;
                if (!m_dfsList.ContainsKey(new_start))
                {
                    new_list = DfsFindPre(new_start);
                }
                else
                {
                    new_list = m_dfsList[new_start];
                }
                for (int j = 0; j < new_list.Count; j++)
                {
                    if (!set.Contains(new_list[j]))
                    {
                        listPre.Add(new_list[j]);
                        set.Add(new_list[j]);
                    }
                }
            }
            m_cheak.Add(start, set);
            m_dfsList.Add(start, listPre);
            return listPre;
        }
    }
}
