using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1301_1400
{
    public class _1391_HasValidPath
    {
        int[][] m_visit;
        bool m_canMeet;
        int m_lenR;
        int m_lenC;
        public bool HasValidPath(int[][] grid)
        {
            m_lenR = grid.Length - 1;
            m_lenC = grid[0].Length - 1;
            if (m_lenC == 0 && m_lenR == 0)
            {
                return true;
            }
            m_canMeet = false;
            m_visit = new int[][] {
            new int[] { 0, 1 }, new int[] { 0, -1 },
            new int[] { 1, 0 }, new int[] { -1, 0 },
            new int[] { 0, -1 }, new int[] { 1, 0 },
            new int[] { 1, 0 }, new int[] { 0, 1 },
            new int[] { 0, -1 }, new int[] { -1, 0 },
            new int[] { 0, 1 }, new int[] { -1, 0 } };
            if (grid[0][0] == 5)
            {
                return false;
            }
            else if (grid[0][0] == 4)
            {
                if (m_lenR > 0)
                {
                    if (pathCells(1, 0, 0, 0, grid))
                    {
                        return true;
                    }
                }
                if (m_lenC > 0 && m_canMeet != true)
                {
                    if (pathCells(0, 1, 0, 0, grid))
                    {
                        return true;
                    }
                }
            }
            else if (grid[0][0] == 2 || grid[0][0] == 3)
            {
                if (m_lenR > 0)
                {
                    if (pathCells(1, 0, 0, 0, grid))
                    {
                        return true;
                    }
                }
            }
            else if (grid[0][0] == 1 || grid[0][0] == 6)
            {
                if (m_lenC > 0)
                {
                    if (pathCells(0, 1, 0, 0, grid))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool pathCells(int row, int col, int come_row, int come_col, int[][] grid)
        {
            if (row == m_lenR && col == m_lenC)
            {
                return true;
            }
            if (row == 0 && col == 0)
            {
                m_canMeet = true;
                return false;
            }
            int start = grid[row][col] * 2 - 2;
            for (int i = 0; i < 2; i++)
            {
                int new_row = row + m_visit[start + i][0];
                int new_col = col + m_visit[start + i][1];
                if (new_row == come_row && new_col == come_col)
                {
                    continue;
                }
                if (new_row < 0 || new_col < 0 || new_col > m_lenC || new_row > m_lenR)
                {
                    continue;
                }
                int back = grid[new_row][new_col] * 2 - 2;
                for (int j = 0; j < 2; j++)
                {
                    int back_row = new_row + m_visit[back + j][0];
                    int back_col = new_col + m_visit[back + j][1];
                    if (back_row == row && back_col == col)
                    {
                        return pathCells(new_row, new_col, row, col, grid);
                    }
                }
            }
            return false;
        }
    }
}
