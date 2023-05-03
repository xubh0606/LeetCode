using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _875_MinEatingSpeed
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int right = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                right = Math.Max(right, piles[i]);
            }
            if (h == piles.Length)
            {
                return right;
            }
            int left = 1;
            while (left < right)//二分查找最小满足情况，其中right为最高值必然可以满足全部吃完，从right开始找起。
            {
                int mid = left + (right - left) / 2;
                if (Cheak(mid, piles, h))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return right;
        }
        bool Cheak(int k, int[] piles, int h)
        {
            for (int i = 0; i < piles.Length; i++)
            {
                if (piles[i] % k == 0)
                {
                    h -= piles[i] / k;
                }
                else
                {
                    h -= piles[i] / k + 1;
                }
            }
            return h >= 0;
        }
    }
}
