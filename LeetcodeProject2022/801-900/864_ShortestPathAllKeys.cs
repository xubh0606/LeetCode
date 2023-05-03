using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _864_ShortestPathAllKeys
    {
        int minCount = int.MaxValue;
        int[][] visit = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
        public int ShortestPathAllKeys(string[] grid)
        {
            int row = 0;
            int col = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            HashSet<char> keys = new HashSet<char>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '@')
                    {
                        row = i;
                        col = j;
                        continue;
                    }
                    int c = grid[i][j] - 'a';
                    if (c >= 0 && c < 26)
                    {
                        keys.Add(grid[i][j]);
                    }
                }
            }
            FindAnotherKey(0, row, col, keys, grid, m, n);
            return minCount == int.MaxValue ? -1 : minCount;
        }
        void FindAnotherKey(int walk, int row, int col, HashSet<char> keys, string[] grid, int m, int n)
        {
            if (walk >= minCount)
            {
                return;
            }
            if (keys.Count == 0)
            {
                minCount = walk;
                return;
            }
            HashSet<Tuple<int, int>> path = new HashSet<Tuple<int, int>>();
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            Tuple<int, int> t = new Tuple<int, int>(row, col);
            path.Add(t);
            q.Enqueue(t);
            int count = 1;
            while (count > 0)
            {
                walk++;
                for (int i = 0; i < count; i++)
                {
                    var tuple = q.Dequeue();
                    int t1 = tuple.Item1;
                    int t2 = tuple.Item2;
                    for (int j = 0; j < 4; j++)
                    {
                        int cur_row = visit[j][0] + t1;
                        int cur_col = visit[j][1] + t2;
                        if (cur_col < 0 || cur_col == n || cur_row < 0 || cur_row == m)
                        {
                            continue;
                        }
                        Tuple<int, int> new_place = new Tuple<int, int>(cur_row, cur_col);
                        if (!path.Contains(new_place))
                        {
                            char c = grid[cur_row][cur_col];
                            if (c == '#')
                            {
                                continue;
                            }
                            else if (keys.Contains((char)(c + 32)))
                            {
                                continue;
                            }
                            else if (keys.Contains(c))
                            {
                                keys.Remove(c);
                                FindAnotherKey(walk, cur_row, cur_col, keys, grid, m, n);
                                keys.Add(c);
                            }
                            q.Enqueue(new_place);
                            path.Add(new_place);
                        }
                    }
                }
                count = q.Count;
            }
        }
    }
}
