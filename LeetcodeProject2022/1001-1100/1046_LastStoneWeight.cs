using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1046_LastStoneWeight
    {
        public int LastStoneWeight(int[] stones)
        {
            int start = stones.Length - 1;
            Array.Sort(stones);
            while (start > 0)
            {
                if (stones[start] == stones[start - 1])
                {
                    start -= 2;
                }
                else
                {
                    start--;
                    int new_stone = start;
                    stones[new_stone] = Math.Abs(stones[start] - stones[start + 1]);
                    while (new_stone > 0 && stones[new_stone] < stones[new_stone - 1])
                    {
                        Swap(stones, new_stone, new_stone - 1);
                        new_stone--;
                    }
                }
            }
            return start == -1 ? 0 : stones[start];
        }
        void Swap(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
