using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1574_FindLengthOfShortestSubarray
    {
        public int FindLengthOfShortestSubarray(int[] arr)
        {
            //假设左侧完全不纳入，则应该删除左侧某些值保证右侧全部为非递减
            int curMax = 0;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    curMax = i + 1;
                    break;
                }
            }
            if (curMax == 0)
            {
                return 0;
            }
            int leftMax = 0;
            while (leftMax < arr.Length - 1 && arr[leftMax] <= arr[curMax] && arr[leftMax] <= arr[leftMax + 1])
            {
                leftMax++;
            }
            int min = Math.Min(arr.Length - leftMax - 1, curMax);
            if (leftMax != 0)
            {
                leftMax--;
            }
            while (true)
            {
                int cur = arr[leftMax];
                while (curMax < arr.Length && arr[curMax] < cur)
                {
                    curMax++;
                }
                min = Math.Min(min, curMax - leftMax - 1);
                if (arr[leftMax] > arr[leftMax + 1])
                {
                    break;
                }
                leftMax++;
            }
            return min;
        }
    }
}
