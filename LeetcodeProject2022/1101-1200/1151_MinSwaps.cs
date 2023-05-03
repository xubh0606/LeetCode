using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1151_MinSwaps
    {
        public int MinSwaps(int[] data)
        {
            int count1 = 0;
            for (int i = 0; i < data.Length; i++)
            {
                count1 += data[i];
            }
            if (count1 == 0 || count1 == data.Length)
            {
                return 0;
            }
            int left = 0;
            int right = count1;
            int areaZero = count1;
            for (int i = 0; i < right; i++)
            {
                areaZero -= data[i];
            }
            int min = areaZero;
            while (right < data.Length)
            {
                if (data[right] == 0)
                {
                    areaZero++;
                }
                if (data[left] == 0)
                {
                    areaZero--;
                }
                min = Math.Min(min, areaZero);
                right++;
                left++;
            }
            return min;
        }
    }
}
