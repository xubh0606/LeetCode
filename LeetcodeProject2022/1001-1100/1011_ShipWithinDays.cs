using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1011_ShipWithinDays
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            int max = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                max = Math.Max(max, weights[i]);
            }
            int test = TryTake(weights, max);
            if (test <= days)
            {
                return max;
            }
            int left = max;
            int right = max * 2;
            while (TryTake(weights, right) > days)
            {
                right *= 2;
            }
            while (left < right)
            {
                int mid = (left + right) / 2;
                test = TryTake(weights, mid);
                if (test > days)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
        int TryTake(int[] weights, int max)
        {
            int count = 1;
            int cur = max;
            for (int i = 0; i < weights.Length; i++)
            {
                if (cur < weights[i])
                {
                    count++;
                    cur = max - weights[i];
                }
                else
                {
                    cur -= weights[i];
                }
            }
            return count;
        }
    }
}
