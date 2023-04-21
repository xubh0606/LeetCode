using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _841_CanVisitAllRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int n = rooms.Count;
            int[] ro = new int[n];
            dfs(ro, rooms, n, 0);
            for (int i = 0; i < n; i++)
            {
                if (ro[i] < 1)
                {
                    return false;
                }
            }
            return true;
        }
        void dfs(int[] ro, IList<IList<int>> rooms, int n, int cur)
        {
            if (ro[cur] > 0)
            {
                return;
            }
            ro[cur] = 1;
            for (int i = 0; i < rooms[cur].Count; i++)
            {
                dfs(ro, rooms, n, rooms[cur][i]);
            }
        }
    }
}
