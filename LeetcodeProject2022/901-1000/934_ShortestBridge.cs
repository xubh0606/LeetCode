using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _934_ShortestBridge
    {
        bool m_isNotConnected = true;
        int[][] m_visit = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { -1, 0 }, new int[] { 1, 0 } };
        public int ShortestBridge(int[][] grid)
        {
            int distance = -1;
            HashSet<Tuple<int, int>> m_island1 = new HashSet<Tuple<int, int>>();
            HashSet<Tuple<int, int>> m_island2 = new HashSet<Tuple<int, int>>();
            Queue<Tuple<int, int>> round1 = new Queue<Tuple<int, int>>();
            Queue<Tuple<int, int>> round2 = new Queue<Tuple<int, int>>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        Tuple<int, int> place = new Tuple<int, int>(i, j);
                        if (m_island1.Count != 0)
                        {
                            if (m_island1.Contains(place))
                            {
                                continue;
                            }
                            m_island2.Add(place);
                            Dfs(m_island2, place, round2, grid);
                            break;
                        }
                        m_island1.Add(place);
                        Dfs(m_island1, place, round1, grid);
                    }
                }
            }
            while (m_isNotConnected)
            {
                distance++;
                if (round1.Count > round2.Count)
                {
                    Update(round2, m_island2, grid, m_island1);
                }
                else
                {
                    Update(round1, m_island1, grid, m_island2);
                }
            }
            return distance;
        }
        void Update(Queue<Tuple<int, int>> round, HashSet<Tuple<int, int>> cur_island, int[][] grid, HashSet<Tuple<int, int>> target_island)
        {
            int count = round.Count;
            for (int i = 0; i < count; i++)
            {
                Tuple<int, int> place = round.Dequeue();
                int row = place.Item1;
                int col = place.Item2;
                for (int j = 0; j < 4; j++)
                {
                    int new_row = row + m_visit[j][0];
                    int new_col = col + m_visit[j][1];
                    if (new_row < 0 || new_col < 0 || new_row == grid.Length || new_col == grid.Length)
                    {
                        continue;
                    }
                    Tuple<int, int> cur_place = new Tuple<int, int>(new_row, new_col);
                    if (cur_island.Contains(cur_place))
                    {
                        continue;
                    }
                    if (target_island.Contains(cur_place))
                    {
                        m_isNotConnected = false;
                        return;
                    }
                    round.Enqueue(cur_place);
                    cur_island.Add(cur_place);
                }
            }
        }
        void Dfs(HashSet<Tuple<int, int>> cur_island, Tuple<int, int> place, Queue<Tuple<int, int>> round, int[][] grid)
        {
            int row = place.Item1;
            int col = place.Item2;
            bool isRound = false;
            for (int i = 0; i < 4; i++)
            {
                int new_row = row + m_visit[i][0];
                int new_col = col + m_visit[i][1];
                if (new_row < 0 || new_col < 0 || new_row == grid.Length || new_col == grid.Length)
                {
                    continue;
                }
                if (grid[new_row][new_col] == 1)
                {
                    Tuple<int, int> new_place = new Tuple<int, int>(new_row, new_col);
                    if (!cur_island.Contains(new_place))
                    {
                        cur_island.Add(new_place);
                        Dfs(cur_island, new_place, round, grid);
                    }
                }
                else
                {
                    isRound = true;
                }
            }
            if (isRound)
            {
                round.Enqueue(place);
            }
        }
    }
}
