using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1504_NumSubmat
    {
        public int NumSubmat(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int[,] leftDistance = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                leftDistance[i, 0] = mat[i][0];
                for (int j = 1; j < n; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        leftDistance[i, j] = leftDistance[i, j - 1] + 1;
                    }
                    else
                    {
                        leftDistance[i, j] = 0;
                    }
                }
            }
            int res = 0;
            for (int j = 0; j < n; j++)
            {
                Stack<Tuple<int, int>> minCountStack = new Stack<Tuple<int, int>>();
                int sum = 0;
                for (int i = 0; i < m; i++)
                {
                    int height = 1;
                    while (minCountStack.Count != 0 && minCountStack.Peek().Item1 > leftDistance[i, j])
                    {
                        Tuple<int, int> tuple = minCountStack.Pop();
                        int row = tuple.Item1;
                        int col = tuple.Item2;
                        height += col;
                        sum -= col * (row - leftDistance[i, j]);
                    }
                    sum += leftDistance[i, j];
                    res += sum;
                    minCountStack.Push(new Tuple<int, int>(leftDistance[i, j], height));
                }
            }
            return res;
        }
    }
}
