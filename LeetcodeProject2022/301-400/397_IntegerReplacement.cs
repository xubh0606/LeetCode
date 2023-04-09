using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _397_IntegerReplacement
    {
        Dictionary<int, int> m_visited;
        public int IntegerReplacement(int n)
        {
            m_visited = new Dictionary<int, int>();
            return FindFast(n);
        }
        int FindFast(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (m_visited.ContainsKey(n))
            {
                return m_visited[n];
            }
            int res;
            if (n % 2 == 0)
            {
                res = FindFast(n / 2) + 1;
                m_visited.Add(n, res);
                return res;
            }
            res = 2 + Math.Min(FindFast(n / 2), FindFast(n / 2 + 1));
            m_visited.Add(n, res);
            return res;
        }
    }
}
