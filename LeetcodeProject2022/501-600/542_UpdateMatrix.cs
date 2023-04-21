using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _542_UpdateMatrix
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        mat[i][j] = m + n;
                        if (i > 0)
                        {
                            mat[i][j] = Math.Min(mat[i][j], 1 + mat[i - 1][j]);
                        }
                        if (j > 0)
                        {
                            mat[i][j] = Math.Min(mat[i][j], 1 + mat[i][j - 1]);
                        }
                    }
                }
            }
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (i < m - 1)
                    {
                        mat[i][j] = Math.Min(mat[i][j], 1 + mat[i + 1][j]);
                    }
                    if (j < n - 1)
                    {
                        mat[i][j] = Math.Min(mat[i][j], 1 + mat[i][j + 1]);
                    }
                }
            }
            return mat;
        }
    }
}
