using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _384_ArrayShuffle
    {
        int[] m_origin;
        Random m_random;
        public _384_ArrayShuffle(int[] nums)
        {
            m_origin = nums;
            m_random = new Random();
        }

        public int[] Reset()
        {
            return m_origin;
        }

        public int[] Shuffle()
        {
            int[] new_nums = new int[m_origin.Length];
            for (int i = 0; i < m_origin.Length; i++)
            {
                new_nums[i] = m_origin[i];
            }
            for (int i = m_origin.Length - 1; i >= 0; i--)
            {
                Swap(new_nums, i, m_random.Next(i + 1));
            }
            return new_nums;
        }
        void Swap(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }

    /**
     * Your Solution object will be instantiated and called as such:
     * Solution obj = new Solution(nums);
     * int[] param_1 = obj.Reset();
     * int[] param_2 = obj.Shuffle();
     */
}
