using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _42_Trap
    {
        int m_left;
        int m_right;
        HashSet<int> m_visited;
        int m_sum;
        public int Trap(int[] height)
        {
            m_sum = 0;
            int[][] height_place = new int[height.Length][];
            for (int i = 0; i < height.Length; i++)
            {
                height_place[i] = new int[2];
                height_place[i][0] = height[i];
                height_place[i][1] = i;
            }
            m_visited = new HashSet<int>();
            Array.Sort(height_place, (a, b) => b[0] - a[0]);
            m_left = height_place[0][1];
            m_right = height_place[0][1];
            m_visited.Add(m_left);
            for (int i = 1; i < height.Length; i++)
            {
                if (!m_visited.Contains(height_place[i][1]))
                {
                    m_visited.Add(height_place[i][1]);
                    SaveWater(height_place[i][1], height);
                }
            }
            return m_sum;
        }
        void SaveWater(int start, int[] height)
        {
            if (start < m_left)
            {
                for (int i = start + 1; i < m_left; i++)
                {
                    m_sum += height[start] - height[i];
                    m_visited.Add(i);
                }
                m_left = start;
            }
            else
            {
                for (int i = m_right + 1; i < start; i++)
                {
                    m_sum += height[start] - height[i];
                    m_visited.Add(i);
                }
                m_right = start;
            }
        }
    }
}
