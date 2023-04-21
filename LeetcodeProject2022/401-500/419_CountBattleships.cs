﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _419_CountBattleships
    {
        public int CountBattleships(char[][] board)
        {
            int count = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'X')
                    {
                        if (i > 0 && board[i - 1][j] == 'X')
                        {
                            continue;
                        }
                        if (j > 0 && board[i][j - 1] == 'X')
                        {
                            continue;
                        }
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
