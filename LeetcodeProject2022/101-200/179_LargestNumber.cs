using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class IntReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            int i = (int)x;
            int j = (int)y;

            if (i == 0 || j == 0)
            {
                return i - j;
            }
            int[] a = new int[9];
            int[] b = new int[9];
            int ii = 0;
            int jj = 0;
            while (i > 0)
            {
                a[ii] = i % 10;
                i = i / 10;
                ii++;
            }
            while (j > 0)
            {
                b[jj] = j % 10;
                j = j / 10;
                jj++;
            }
            jj--;
            ii--;
            long i1 = 0;
            for (int temp = ii; temp >= 0; temp--)
            {
                i1 = 10 * i1 + a[temp];
            }
            for (int temp = jj; temp >= 0; temp--)
            {
                i1 = 10 * i1 + b[temp];
            }
            long j1 = 0;
            for (int temp = jj; temp >= 0; temp--)
            {
                j1 = 10 * j1 + b[temp];
            }
            for (int temp = ii; temp >= 0; temp--)
            {
                j1 = 10 * j1 + a[temp];
            }
            if (i1 > j1)
            {
                return 1;
            }
            return -1;
        }
    }
    public class _179_LargestNumber
    {

        public string LargestNumber(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums[0].ToString();
            }
            IntReverseComparer comparer = new IntReverseComparer();
            Array.Sort(nums, comparer);
            if (nums[nums.Length - 1] == 0)
            {
                return "0";
            }
            StringBuilder sb = new StringBuilder();
            for (int i = nums.Length - 1; i > -1; i--)
            {
                sb.Append(nums[i].ToString());
            }
            return sb.ToString();
        }
    }
}
