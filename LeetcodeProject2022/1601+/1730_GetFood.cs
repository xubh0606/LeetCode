using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _1730_GetFood
    {
        int m_startRow = 0;
        int m_startCol = 0;
        int[][] m_visit;
        public int GetFood(char[][] grid)
        {
            m_visit = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
            FindStart(grid);
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
            Queue<Tuple<int, int>> searchFood = new Queue<Tuple<int, int>>();
            Tuple<int, int> start = new Tuple<int, int>(m_startRow, m_startCol);
            searchFood.Enqueue(start);
            visited.Add(start);
            int count = 1;
            int distance = 1;
            while (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Tuple<int, int> cur = searchFood.Dequeue();
                    for (int j = 0; j < 4; j++)
                    {
                        int new_row = cur.Item1 + m_visit[j][0];
                        int new_col = cur.Item2 + m_visit[j][1];
                        if (new_col < 0 || new_col == grid[0].Length || new_row < 0 || new_row == grid.Length)
                        {
                            continue;
                        }
                        if (grid[new_row][new_col] == '#')
                        {
                            return distance;
                        }
                        if (grid[new_row][new_col] == 'X')
                        {
                            continue;
                        }
                        Tuple<int, int> new_place = new Tuple<int, int>(new_row, new_col);
                        if (!visited.Contains(new_place))
                        {
                            searchFood.Enqueue(new_place);
                            visited.Add(new_place);
                        }
                    }
                }
                distance++;
                count = searchFood.Count;
            }
            return -1;
        }
        void FindStart(char[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '*')
                    {
                        m_startRow = i;
                        m_startCol = j;
                        return;
                    }
                }
            }
        }
    }
}
