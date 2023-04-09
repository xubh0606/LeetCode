using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _529_UpdateBoard
    {
        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            if (board[click[0]][click[1]] == 'M')
            {
                board[click[0]][click[1]] = 'X';
                return board;
            }
            else if (board[click[0]][click[1]] == 'E')
            {
                dfs(click[0], click[1], board);
                return board;
            }
            else
            {
                return board;
            }
        }
        void dfs(int c1, int c2, char[][] board)
        {
            if (c1 < 0 || c1 >= board.Length || c2 < 0 || c2 >= board[0].Length)
            {
                return;
            }
            int num = numberOfBoom(c1, c2, board);
            if (board[c1][c2] == 'E' && num == 0)
            {
                board[c1][c2] = 'B';
                dfs(c1 - 1, c2, board);
                dfs(c1 + 1, c2, board);
                dfs(c1 - 1, c2 - 1, board);
                dfs(c1 + 1, c2 + 1, board);
                dfs(c1, c2 + 1, board);
                dfs(c1, c2 - 1, board);
                dfs(c1 - 1, c2 + 1, board);
                dfs(c1 + 1, c2 - 1, board);
            }
            else if (board[c1][c2] == 'E' && num != 0)
            {
                board[c1][c2] = (char)('0' + num);
            }
            return;
        }
        int numberOfBoom(int c1, int c2, char[][] board)
        {
            int num = 0;
            if (c1 > 0)
            {
                if (c2 > 0)
                {
                    if (board[c1 - 1][c2 - 1] == 'M')
                    {
                        num++;
                    }
                }
                if (board[c1 - 1][c2] == 'M')
                {
                    num++;
                }
                if (c2 < board[0].Length - 1)
                {
                    if (board[c1 - 1][c2 + 1] == 'M')
                    {
                        num++;
                    }
                }
            }
            if (c2 > 0)
            {
                if (board[c1][c2 - 1] == 'M')
                {
                    num++;
                }
            }
            if (c2 < board[0].Length - 1)
            {
                if (board[c1][c2 + 1] == 'M')
                {
                    num++;
                }
            }
            if (c1 < board.Length - 1)
            {
                if (c2 > 0)
                {
                    if (board[c1 + 1][c2 - 1] == 'M')
                    {
                        num++;
                    }
                }
                if (board[c1 + 1][c2] == 'M')
                {
                    num++;
                }
                if (c2 < board[0].Length - 1)
                {
                    if (board[c1 + 1][c2 + 1] == 'M')
                    {
                        num++;
                    }
                }
            }
            return num;
        }
    }
}
