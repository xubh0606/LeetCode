using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _490_HasPath
    {
        HashSet<string> m_set = new HashSet<string>();
        public bool HasPath(int[][] maze, int[] start, int[] destination)
        {
            string s = $"{destination[0]}c{destination[1]}";
            int n = maze.Length;
            int m = maze[0].Length;
            m_set.Add($"{start[0]}c{start[1]}");
            if (m_set.Contains(s))
            {
                return true;
            }
            return TraceBack(maze, start, s, 0, n, m) ||
            TraceBack(maze, start, s, 1, n, m) ||
            TraceBack(maze, start, s, 2, n, m) ||
            TraceBack(maze, start, s, 3, n, m);
        }
        bool TraceBack(int[][] maze, int[] start, string end, int direction, int n, int m)
        {
            bool notChanged = true;
            int[] newStart = new int[2];
            if (direction == 0)
            {
                newStart[0] = start[0];
                int row = start[0];
                for (int i = start[1] + 1; i < m; i++)
                {
                    if (maze[row][i] == 1)
                    {
                        newStart[1] = i - 1;
                        notChanged = false;
                        break;
                    }
                }
                if (notChanged)
                {
                    newStart[1] = m - 1;
                }
                string s = $"{newStart[0]}c{newStart[1]}";
                if (s == end)
                {
                    return true;
                }
                if (!m_set.Contains(s))
                {
                    m_set.Add(s);
                    return
                    TraceBack(maze, newStart, end, 2, n, m) ||
                    TraceBack(maze, newStart, end, 3, n, m);
                }
                return false;
            }
            else if (direction == 1)
            {
                newStart[0] = start[0];
                int row = start[0];
                for (int i = start[1] - 1; i >= 0; i--)
                {
                    if (maze[row][i] == 1)
                    {
                        newStart[1] = i + 1;
                        notChanged = false;
                        break;
                    }
                }

                if (notChanged)
                {
                    newStart[1] = 0;
                }
                string s = $"{newStart[0]}c{newStart[1]}";
                if (s == end)
                {
                    return true;
                }
                if (!m_set.Contains(s))
                {
                    m_set.Add(s);
                    return
                    TraceBack(maze, newStart, end, 2, n, m) ||
                    TraceBack(maze, newStart, end, 3, n, m);
                }
                return false;
            }
            else if (direction == 2)
            {
                newStart[1] = start[1];
                int col = start[1];
                for (int i = start[0] + 1; i < n; i++)
                {
                    if (maze[i][col] == 1)
                    {
                        newStart[0] = i - 1;
                        notChanged = false;
                        break;
                    }
                }

                if (notChanged)
                {
                    newStart[0] = n - 1;
                }
                string s = $"{newStart[0]}c{newStart[1]}";

                if (s == end)
                {
                    return true;
                }
                if (!m_set.Contains(s))
                {
                    m_set.Add(s);
                    return TraceBack(maze, newStart, end, 0, n, m) ||
                    TraceBack(maze, newStart, end, 1, n, m)
                    ;
                }
                return false;
            }
            else
            {
                newStart[1] = start[1];
                int col = start[1];
                for (int i = start[0] - 1; i >= 0; i--)
                {
                    if (maze[i][col] == 1)
                    {
                        newStart[0] = i + 1;
                        notChanged = false;
                        break;
                    }
                }

                if (notChanged)
                {
                    newStart[0] = 0;
                }
                string s = $"{newStart[0]}c{newStart[1]}";
                if (s == end)
                {
                    return true;
                }
                if (!m_set.Contains(s))
                {
                    m_set.Add(s);
                    return TraceBack(maze, newStart, end, 0, n, m) ||
                    TraceBack(maze, newStart, end, 1, n, m)
                    ;
                }
                return false;
            }
        }
    }
}
