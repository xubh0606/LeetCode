using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _251_Vector2D
    {
        int[] m_vec;
        int m_count;
        int m_length;
        public _251_Vector2D(int[][] vec)
        {
            IList<int> list = new List<int>();
            for (int i = 0; i < vec.Length; i++)
            {
                for (int j = 0; j < vec[i].Length; j++)
                {
                    list.Add(vec[i][j]);
                }
            }
            m_vec = list.ToArray();
            m_length = m_vec.Length;
            m_count = -1;
        }

        public int Next()
        {
            m_count++;
            if (m_count < m_length)
            {
                return m_vec[m_count];
            }
            else
            {
                throw new Exception();
            }
        }

        public bool HasNext()
        {
            if (m_count < m_length - 1)
            {
                return true;
            }
            return false;
        }
    }

    /**
     * Your Vector2D object will be instantiated and called as such:
     * Vector2D obj = new Vector2D(vec);
     * int param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}
