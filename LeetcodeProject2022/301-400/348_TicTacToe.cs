using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _348_TicTacToe
    {
        int[] m_row;
        int[] m_col;
        int m_total1;
        int m_total2;
        int m_diagonal1;
        int m_diagonal2;
        public _348_TicTacToe(int n)
        {
            m_col = new int[n];
            m_row = new int[n];
            m_diagonal1 = 0;
            m_diagonal2 = 0;
            m_total1 = n;
            m_total2 = 0 - n;
        }

        public int Move(int row, int col, int player)
        {
            if (player == 1)
            {
                m_col[col]++;
                m_row[row]++;
                if (row == col)
                {
                    m_diagonal1++;
                }
                if (row + col + 1 == m_total1)
                {
                    m_diagonal2++;
                }
            }
            else
            {
                m_col[col]--;
                m_row[row]--;
                if (row == col)
                {
                    m_diagonal1--;
                }
                if (row + col + 1 == m_total1)
                {
                    m_diagonal2--;
                }
            }
            if (m_diagonal1 == m_total1 || m_diagonal2 == m_total1)
            {
                return 1;
            }
            if (m_diagonal1 == m_total2 || m_diagonal2 == m_total2)
            {
                return 2;
            }
            for (int i = 0; i < m_total1; i++)
            {
                if (m_row[i] == m_total1 || m_col[i] == m_total1)
                {
                    return 1;
                }
                if (m_row[i] == m_total2 || m_col[i] == m_total2)
                {
                    return 2;
                }
            }
            return 0;
        }
    }

    /**
     * Your TicTacToe object will be instantiated and called as such:
     * TicTacToe obj = new TicTacToe(n);
     * int param_1 = obj.Move(row,col,player);
     */
}
