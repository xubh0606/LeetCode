using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _130_SolveArea
    {
        public void Solve(char[][] board)
        {
            int n = board.Length;
            int m = board[0].Length;
            HashSet<long> set = new HashSet<long>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        long temp = ((long)i << 32) + j;
                        if (set.Contains(temp))
                        {
                            continue;
                        }
                        IList<int> list = new List<int>();
                        if (!dfs(board, i, j, n, m, set, list))
                        {
                            int p = 0;
                            while (p < list.Count)
                            {
                                int x = list[p];
                                p++;
                                int y = list[p];
                                p++;
                                board[x][y] = 'X';
                            }
                        }
                    }
                }
            }
        }
        bool dfs(char[][] board, int row, int col, int n, int m, HashSet<long> set, IList<int> list)
        {
            if (row < 0 || row >= n || col < 0 || col >= m)
            {
                return true;
            }
            long l = ((long)row << 32) + col;
            if (set.Contains(l) || board[row][col] == 'X')
            {
                return false;
            }
            set.Add(l);
            list.Add(row);
            list.Add(col);
            bool b1 = dfs(board, row - 1, col, n, m, set, list);
            bool b2 = dfs(board, row + 1, col, n, m, set, list);
            bool b3 = dfs(board, row, col - 1, n, m, set, list);
            bool b4 = dfs(board, row, col + 1, n, m, set, list);
            if (b1 || b2 || b3 || b4)
            {
                return true;
            }
            return false;
        }
    }
}
