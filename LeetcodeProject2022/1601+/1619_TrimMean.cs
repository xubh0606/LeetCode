using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _1619_TrimMean
    {
        public double TrimMean(int[] arr)
        {
            Array.Sort(arr);
            int n = arr.Length;
            int Nof20 = n / 20;
            double sum = 0;
            for (int i = Nof20; i < n - Nof20; i++)
            {
                sum = sum + arr[i];
            }
            return sum / (n * 9 / 10);
        }
    }
}
