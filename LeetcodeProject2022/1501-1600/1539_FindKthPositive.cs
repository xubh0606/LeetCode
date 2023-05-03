using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1539_FindKthPositive
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) >> 1;
                if (arr[mid] - mid - 1 < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left + k;
        }
    }
}
