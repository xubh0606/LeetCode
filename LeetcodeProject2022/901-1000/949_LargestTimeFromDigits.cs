using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _949_LargestTimeFromDigits
    {
        public string LargestTimeFromDigits(int[] arr)
        {
            Array.Sort(arr);
            string res = "";
            if (arr[0] >= 3 || (arr[0] == 2 && arr[1] >= 5))
            {
                return res;
            }
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    int temp = arr[i] * 10 + arr[j];
                    if (temp < 24)
                    {
                        res = arr[i].ToString() + arr[j].ToString() + ":";
                        for (int a = 3; a >= 0; a--)
                        {
                            if (a == i || a == j)
                            {
                                continue;
                            }
                            for (int b = 3; b >= 0; b--)
                            {
                                if (b == i || b == j || a == b)
                                {
                                    continue;
                                }
                                int temp1 = arr[a] * 10 + arr[b];
                                if (temp1 < 60)
                                {
                                    res = res + arr[a].ToString() + arr[b].ToString();
                                    return res;
                                }
                            }
                        }
                    }
                }
            }
            return "";
        }
    }
}
