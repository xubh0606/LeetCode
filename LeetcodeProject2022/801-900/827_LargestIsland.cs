using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _827_LargestIsland
    {
        private int n;
        private int[] p;
        private int[] size;
        private int ans = 1;
        private int[] dirs = new int[] { -1, 0, 1, 0, -1 };

        public int LargestIsland(int[][] grid)
        {
            n = grid.Length;
            p = new int[n * n];
            size = new int[n * n];
            for (int i = 0; i < p.Length; ++i)
            {
                p[i] = i;
                size[i] = 1;
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 1)
                    {
                        for (int k = 0; k < 4; ++k)
                        {
                            int x = i + dirs[k], y = j + dirs[k + 1];
                            if (x >= 0 && x < n && y >= 0 && y < n && grid[x][y] == 1)
                            {
                                int pa = find(x * n + y), pb = find(i * n + j);
                                if (pa == pb)
                                {
                                    continue;
                                }
                                p[pa] = pb;
                                size[pb] += size[pa];
                                ans = Math.Max(ans, size[pb]);
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 0)
                    {
                        int t = 1;
                        HashSet<int> vis = new HashSet<int>();
                        for (int k = 0; k < 4; ++k)
                        {
                            int x = i + dirs[k], y = j + dirs[k + 1];
                            if (x >= 0 && x < n && y >= 0 && y < n && grid[x][y] == 1)
                            {
                                int root = find(x * n + y);
                                if (!vis.Contains(root))
                                {
                                    vis.Add(root);
                                    t += size[root];
                                }
                            }
                        }
                        ans = Math.Max(ans, t);
                    }
                }
            }
            return ans;
        }

        private int find(int x)
        {
            if (p[x] != x)
            {
                p[x] = find(p[x]);
            }
            return p[x];
        }
    }
}
