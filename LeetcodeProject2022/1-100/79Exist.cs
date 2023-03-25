using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _79Exist
    {
        public bool Exist(char[][] board, string word)
        {
            int[,] m = new int[board.Length, board[0].Length];
            int count = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (dfs(i, j, word, board, count, m))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        bool dfs(int i, int j, string word, char[][] board, int count, int[,] m)
        {
            if (i >= board.Length || i < 0 || j >= board[0].Length || j < 0)
            {
                return false;
            }
            if (m[i, j] == 1)
            {
                return false;
            }
            if (count == word.Length - 1)
            {
                if (word[count] == board[i][j])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (word[count] == board[i][j])
            {
                m[i, j] = 1;
                if (dfs(i + 1, j, word, board, count + 1, m) || dfs(i - 1, j, word, board, count + 1, m) || dfs(i, j + 1, word, board, count + 1, m) || dfs(i, j - 1, word, board, count + 1, m))
                {
                    return true;
                }
                m[i, j] = 0;
            }
            return false;
        }
    }
}
