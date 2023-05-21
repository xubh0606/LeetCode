using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _84_LargestRectangleArea
    {
        public int LargestRectangleArea(int[] heights)
        {
            int max = heights[0];
            Stack<int> update = new Stack<int>();
            int[] new_arr = new int[heights.Length + 2];
            for (int i = 0; i < heights.Length; i++)
            {
                new_arr[i + 1] = heights[i];
            }
            heights = new_arr;
            update.Push(0);
            for (int i = 1; i < heights.Length; i++)
            {
                while (heights[i] < heights[update.Peek()])
                {
                    int lastIndex = update.Pop();
                    max = Math.Max(max, heights[lastIndex] * (i - update.Peek() - 1));
                }
                update.Push(i);
            }
            return max;
        }
    }
}
