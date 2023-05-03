using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _773_SlidingPuzzle
    {
        int row = 0;
        int col = 0;
        int[][] visit = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
        public int SlidingPuzzle(int[][] board)
        {
            Queue<int> q = new Queue<int>();
            HashSet<int> set = new HashSet<int>();
            int b = puzzle(board);
            q.Enqueue(b);
            set.Add(b);
            int count = 0;
            while (q.Count > 0)
            {
                int c = q.Count;
                for (int i = 0; i < c; i++)
                {
                    b = q.Dequeue();
                    if (b == 123450)
                    {
                        return count;
                    }
                    int[][] newBoard = rePuzzle(b, board);
                    for (int j = 0; j < 4; j++)
                    {
                        int ro = row + visit[j][0];
                        int co = col + visit[j][1];
                        if (ro < 0 || ro > 1 || co < 0 || co > 2)
                        {
                            continue;
                        }
                        int nb = puzzle(newBoard, co, ro);
                        if (!set.Contains(nb))
                        {
                            set.Add(nb);
                            q.Enqueue(nb);
                        }
                    }
                }
                count++;
            }
            return -1;
        }
        int puzzle(int[][] board, int co, int ro)
        {
            int p = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == ro && j == co)
                    {
                        p = p * 10;
                    }
                    else if (i == row && j == col)
                    {
                        p = p * 10 + board[ro][co];
                    }
                    else
                    {
                        p = p * 10 + board[i][j];
                    }
                }
            }
            return p;
        }
        int puzzle(int[][] board)
        {
            int p = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    p = p * 10 + board[i][j];
                }
            }
            return p;
        }
        int[][] rePuzzle(int b, int[][] board)
        {
            int[][] newBoard = (int[][])board.Clone();
            for (int i = 1; i > -1; i--)
            {
                for (int j = 2; j > -1; j--)
                {
                    int cur = b % 10;
                    board[i][j] = cur;
                    if (cur == 0)
                    {
                        col = j;
                        row = i;
                    }
                    b /= 10;
                }
            }
            return newBoard;
        }
    }
}
