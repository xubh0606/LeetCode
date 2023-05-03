using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _1566_ContainsPattern
    {
        public bool ContainsPattern(int[] arr, int m, int k)
        {
            int i = 0;
            bool contain = true;
            while (i < (arr.Length - m * k + 1))
            {
                for (int l = 0; l < m; l++)
                {
                    for (int n = 1; n < k; n++)
                    {
                        if (arr[i + l] != arr[i + n * m + l])
                        {
                            contain = false;
                            break;
                        }
                    }
                    if (contain == false)
                    {
                        break;
                    }
                }
                if (contain == true)
                {
                    return true;
                }
                i++;
                contain = true;
            }
            return false;
        }
    }
}
