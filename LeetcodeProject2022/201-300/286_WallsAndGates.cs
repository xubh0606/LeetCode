using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _286_WallsAndGates
    {
        public void WallsAndGates(int[][] rooms)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[0].Length; j++)
                {
                    dfs(rooms, i, j, rooms[i][j]);
                }
            }
        }
        void dfs(int[][] rooms, int row, int col, int d)
        {
            if (col < 0 || col == rooms[0].Length || row < 0 || row == rooms.Length)
            {
                return;
            }
            if (rooms[row][col] == -1)
            {
                return;
            }
            if (rooms[row][col] <= d && d != 0)
            {
                return;
            }
            rooms[row][col] = d;
            dfs(rooms, row - 1, col, rooms[row][col] + 1);
            dfs(rooms, row, col - 1, rooms[row][col] + 1);
            dfs(rooms, row + 1, col, rooms[row][col] + 1);
            dfs(rooms, row, col + 1, rooms[row][col] + 1);
        }
    }
}
