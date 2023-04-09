using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _311_Multiply
    {
        //给定两个 稀疏矩阵 ：大小为 m x k 的稀疏矩阵 mat1 和大小为 k x n 的稀疏矩阵 mat2
        //返回 mat1 x mat2 的结果。你可以假设乘法总是可能的。
        public int[][] Multiply(int[][] mat1, int[][] mat2)
        {
            IList<IList<int>> dicList = new List<IList<int>>();
            for (int i = 0; i < mat2[0].Length; i++)
            {
                IList<int> dic = new List<int>();
                for (int j = 0; j < mat2.Length; j++)
                {
                    if (mat2[j][i] != 0)
                    {
                        dic.Add(j);
                    }
                }
                dicList.Add(dic);
            }
            IList<int[]> res = new List<int[]>();
            for (int i = 0; i < mat1.Length; i++)
            {
                IList<int> set = new List<int>();
                int[] arr = new int[mat2[0].Length];
                for (int j = 0; j < mat1[0].Length; j++)
                {
                    if (mat1[i][j] != 0)
                    {
                        set.Add(j);
                    }
                }
                for (int k = 0; k < dicList.Count; k++)
                {
                    int sum = 0;
                    int a = 0;
                    int b = 0;
                    while (a < set.Count && b < dicList[k].Count)
                    {
                        int a1 = set[a];
                        int b1 = dicList[k][b];
                        if (a1 == b1)
                        {
                            sum += mat1[i][a1] * mat2[a1][k];
                            a++;
                            b++;
                        }
                        else if (a1 > b1)
                        {
                            b++;
                        }
                        else
                        {
                            a++;
                        }
                    }
                    arr[k] = sum;
                }
                res.Add(arr);
            }
            return res.ToArray();
        }
    }
}
