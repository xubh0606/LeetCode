using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300
{
    public class _1210_MinimumMoves
    {
        int m_n;
        public int MinimumMoves(int[][] grid)
        {
            m_n = grid.Length;
            Tuple<int, int, int> origin = new Tuple<int, int, int>(0, 0, 0);//代表位置row，col，状态横向
            HashSet<Tuple<int, int, int>> visited = new HashSet<Tuple<int, int, int>>();
            Queue<Tuple<int, int, int>> move = new Queue<Tuple<int, int, int>>();
            int distance = 0;
            move.Enqueue(origin);
            visited.Add(origin);
            while (move.Count > 0)
            {
                int c = move.Count;
                for (int i = 0; i < c; i++)
                {
                    Tuple<int, int, int> place = move.Dequeue();
                    int row = place.Item1;
                    int col = place.Item2;
                    int state = place.Item3;
                    if (row == m_n - 1 && col == m_n - 2 && state == 0)
                    {
                        return distance;
                    }
                    CheakRightDownSwitch(move, visited, row, col, state, grid);
                }
                distance++;
            }
            return -1;
        }
        void CheakRightDownSwitch(Queue<Tuple<int, int, int>> move, HashSet<Tuple<int, int, int>> visited, int row, int col, int state, int[][] grid)
        {
            if (state == 0)
            {
                //先确认另一个位置
                int col2 = col + 1;
                //进行移动或旋转，此时旋转为下转
                //旋转
                int down = row + 1;
                if (down < m_n && grid[down][col] == 0)
                {
                    Tuple<int, int, int> next_place = new Tuple<int, int, int>(row, col, 1);
                    if (!visited.Contains(next_place))
                    {
                        visited.Add(next_place);
                        move.Enqueue(next_place);
                    }
                    //下移
                    if (grid[down][col2] == 0)
                    {
                        Tuple<int, int, int> next_place2 = new Tuple<int, int, int>(down, col, 0);
                        if (!visited.Contains(next_place2))
                        {
                            visited.Add(next_place2);
                            move.Enqueue(next_place2);
                        }
                    }
                }
                //右移
                int col3 = col2 + 1;
                if (col3 < m_n && grid[row][col3] == 0)
                {
                    Tuple<int, int, int> next_place = new Tuple<int, int, int>(row, col2, 0);
                    if (!visited.Contains(next_place))
                    {
                        visited.Add(next_place);
                        move.Enqueue(next_place);
                    }
                }
            }
            else
            {
                //先确认另一个位置
                int row2 = row + 1;
                //进行移动或旋转，此时旋转为右转
                //旋转
                int right = col + 1;
                if (right < m_n && grid[row][right] == 0)
                {
                    Tuple<int, int, int> next_place = new Tuple<int, int, int>(row, col, 0);
                    if (!visited.Contains(next_place))
                    {
                        visited.Add(next_place);
                        move.Enqueue(next_place);
                    }
                    //右移
                    if (grid[row2][right] == 0)
                    {
                        Tuple<int, int, int> next_place2 = new Tuple<int, int, int>(row, right, 1);
                        if (!visited.Contains(next_place2))
                        {
                            visited.Add(next_place2);
                            move.Enqueue(next_place2);
                        }
                    }
                }
                //下移
                int row3 = row2 + 1;
                if (row3 < m_n && grid[row3][col] == 0)
                {
                    Tuple<int, int, int> next_place = new Tuple<int, int, int>(row2, col, 1);
                    if (!visited.Contains(next_place))
                    {
                        visited.Add(next_place);
                        move.Enqueue(next_place);
                    }
                }
            }
        }
    }
}
