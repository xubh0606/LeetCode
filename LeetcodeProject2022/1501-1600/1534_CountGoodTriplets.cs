using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1534_CountGoodTriplets
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
