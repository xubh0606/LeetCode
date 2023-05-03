using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1519_CountSubTrees
    {
        Dictionary<int, IList<int>> m_nearby;
        int[] m_res;
        string m_labels;
        public int[] CountSubTrees(int n, int[][] edges, string labels)
        {
            m_labels = labels;
            m_nearby = new Dictionary<int, IList<int>>();
            m_res = new int[n];
            for (int i = 0; i < n; i++)
            {
                m_nearby.Add(i, new List<int>());
            }
            for (int i = 0; i < n - 1; i++)
            {
                int left = edges[i][0];
                int right = edges[i][1];
                m_nearby[left].Add(right);
                m_nearby[right].Add(left);
            }
            GetCount(0, -1);
            return m_res;
        }
        int[] GetCount(int cur_num, int father)
        {
            IList<int> list = m_nearby[cur_num];
            int[] sum = new int[26];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == father)
                {
                    continue;
                }
                int[] get = GetCount(list[i], cur_num);
                for (int j = 0; j < 26; j++)
                {
                    sum[j] += get[j];
                }
            }
            int temp = m_labels[cur_num] - 'a';
            sum[temp]++;
            m_res[cur_num] = sum[temp];
            return sum;
        }
    }
}
