using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _386_LexicalOrder
    {
        public IList<int> LexicalOrder(int n)
        {
            IList<int> list = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                dfs(i, n, list);
            }
            return list;
        }

        void dfs(int i, int max, IList<int> list)
        {
            if (i > max)
            {
                return;
            }
            list.Add(i);
            i *= 10;
            for (int j = i; j < i + 10; j++)
            {
                dfs(j, max, list);
            }
        }
    }
}
