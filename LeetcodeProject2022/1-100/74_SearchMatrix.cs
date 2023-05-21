using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _74_SearchMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int head = FindHead(matrix, target);
            if (head < 0)
            {
                return false;
            }
            if (matrix[head][0] == target)
            {
                return true;
            }
            return FindNum(matrix[head], target);
        }
        int FindHead(int[][] matrix, int target)
        {
            int up = 0;
            int down = matrix.Length - 1;
            while (up < down)
            {
                int mid = up + (down - up) / 2;
                int cur = matrix[mid][0];
                if (cur == target)
                {
                    return mid;
                }
                if (cur < target)
                {
                    up = mid + 1;
                }
                else
                {
                    down = mid - 1;
                }
            }
            if (matrix[up][0] > target)
            {
                return up - 1;
            }
            return up;
        }
        bool FindNum(int[] headArr, int target)
        {
            int left = 1;
            int right = headArr.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (headArr[mid] == target)
                {
                    return true;
                }
                if (headArr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left >= 0 && left < headArr.Length && headArr[left] == target;
        }
    }
}
