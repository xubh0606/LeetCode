using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1458_MaxDotProduct
    {
        public int MaxDotProduct(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[,] maxSumCur = new int[m + 1, n + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    maxSumCur[i + 1, j + 1] = Math.Max(maxSumCur[i + 1, j], maxSumCur[i, j + 1]);
                    maxSumCur[i + 1, j + 1] = Math.Max(maxSumCur[i, j] + nums1[i] * nums2[j], maxSumCur[i + 1, j + 1]);
                }
            }
            if (maxSumCur[m, n] == 0)
            {
                int min = nums2[0];
                int max = nums2[0];
                for (int i = 1; i < n; i++)
                {
                    min = Math.Min(min, nums2[i]);
                    max = Math.Max(max, nums2[i]);
                }
                if (max == 0)
                {
                    return 0;
                }
                else if (max < 0)
                {
                    min = nums1[0];
                    for (int i = 1; i < m; i++)
                    {
                        min = Math.Min(min, nums1[i]);
                    }
                    return min * max;
                }
                else
                {
                    max = nums1[0];
                    for (int i = 1; i < m; i++)
                    {
                        max = Math.Max(max, nums1[i]);
                    }
                    return min * max;
                }
            }
            return maxSumCur[m, n];
        }
    }
}
