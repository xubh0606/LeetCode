using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _755_PourWater
    {
        public int[] PourWater(int[] heights, int volume, int k)
        {
            int len = heights.Length;
            while (volume > 0)
            {
                if (k > 0 && heights[k] >= heights[k - 1])
                {
                    volume = FillLeft(heights, volume, k);
                }
                if (k < len - 1 && heights[k] >= heights[k + 1])
                {
                    volume = FillRight(heights, volume, k);
                }
                if (volume > 0)
                {
                    volume--;
                    heights[k]++;
                }
            }
            return heights;
        }
        int FillLeft(int[] heights, int volume, int k)
        {
            int i = k - 2;
            int total = heights[k] - heights[k - 1];
            while (i >= 0 && heights[i] <= heights[k])
            {
                total += heights[k] - heights[i];
                i--;
            }
            if (total < volume)
            {
                i++;
                for (; i < k; i++)
                {
                    heights[i] = heights[k];
                }
                return volume - total;
            }
            PourWater(heights, volume, k - 1);
            return 0;
        }
        int FillRight(int[] heights, int volume, int k)
        {
            int i = k + 2;
            int total = heights[k] - heights[k + 1];
            while (i < heights.Length && heights[i] <= heights[k])
            {
                total += heights[k] - heights[i];
                i++;
            }
            if (total < volume)
            {
                i--;
                for (; i > k; i--)
                {
                    heights[i] = heights[k];
                }
                return volume - total;
            }
            PourWater(heights, volume, k + 1);
            return 0;
        }
    }
}
