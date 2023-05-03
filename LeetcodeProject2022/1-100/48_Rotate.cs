using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _48_Rotate
    {
        int m_len;
        public void Rotate(int[][] matrix)
        {
            m_len = matrix.Length - 1;
            int length = matrix.Length % 2 == 1 ? matrix.Length / 2 + 1 : matrix.Length / 2;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < matrix.Length / 2; j++)
                {
                    Tuple<int, int>[] nextIndex = NextIndex(i, j);
                    int temp1 = matrix[i][j];
                    matrix[i][j] = matrix[nextIndex[2].Item1][nextIndex[2].Item2];
                    matrix[nextIndex[2].Item1][nextIndex[2].Item2] = matrix[nextIndex[1].Item1][nextIndex[1].Item2];
                    matrix[nextIndex[1].Item1][nextIndex[1].Item2] = matrix[nextIndex[0].Item1][nextIndex[0].Item2];
                    matrix[nextIndex[0].Item1][nextIndex[0].Item2] = temp1;
                }
            }
        }
        Tuple<int, int>[] NextIndex(int row, int col)
        {
            Tuple<int, int>[] index = new Tuple<int, int>[3];
            index[0] = new Tuple<int, int>(col, m_len - row);
            index[1] = new Tuple<int, int>(m_len - row, m_len - col);
            index[2] = new Tuple<int, int>(m_len - col, row);
            return index;
        }
    }
}
