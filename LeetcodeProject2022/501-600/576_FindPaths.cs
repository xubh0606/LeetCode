using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _576_FindPaths
    {
        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            if (maxMove == 0)
            {
                return 0;
            }
            int[][] visit = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, -1 } };
            int res = 0;
            Queue<Tuple<int, int>> possiblePlace = new Queue<Tuple<int, int>>();
            int[,] grid = new int[m, n];
            grid[startRow, startColumn] = 1;
            possiblePlace.Enqueue(new Tuple<int, int>(startRow, startColumn));
            int count = 1;
            int move = 0;
            while (count > 0)
            {
                int[,] nextGrid = new int[m, n];
                HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
                for (int i = 0; i < count; i++)
                {
                    Tuple<int, int> start = possiblePlace.Dequeue();
                    int times = grid[start.Item1, start.Item2];
                    for (int j = 0; j < 4; j++)
                    {
                        int endRow = start.Item1 + visit[j][0];
                        int endCol = start.Item2 + visit[j][1];
                        if (endRow < 0 || endRow == m || endCol < 0 || endCol == n)
                        {
                            res += times;
                            res %= 1000000007;
                        }
                        else
                        {
                            nextGrid[endRow, endCol] += times;
                            nextGrid[endRow, endCol] %= 1000000007;
                            Tuple<int, int> end = new Tuple<int, int>(endRow, endCol);
                            if (!visited.Contains(end))
                            {
                                visited.Add(end);
                                possiblePlace.Enqueue(end);
                            }
                        }
                    }
                }
                move++;
                if (move == maxMove)
                {
                    return res;
                }
                count = possiblePlace.Count;
                grid = nextGrid;
            }
            return res;
        }
    }
}
