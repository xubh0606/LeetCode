using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _73_SetZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            bool isChangedZero = false;
            int m = matrix.Length;
            int n = matrix[0].Length;
            for (int k = 0; k < n; k++)
            {
                if (matrix[0][k] == 0)
                {
                    isChangedZero = true;
                    break;
                }
            }
            for (int i = 1; i < m; i++)
            {
                bool isChangedNow = false;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        isChangedNow = true;
                        matrix[0][j] = 0;
                    }
                }
                if (isChangedNow == true)
                {
                    for (int l = 0; l < n; l++)
                    {
                        matrix[i][l] = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (matrix[0][i] == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[j][i] = 0;
                    }
                }
            }
            if (isChangedZero == true)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[0][i] = 0;
                }
            }
        }
    }
}
