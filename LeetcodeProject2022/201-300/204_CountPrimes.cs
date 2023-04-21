using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _204_CountPrimes
    {
        public int CountPrimes(int n)
        {
            int index = 0;
            int[] nums = new int[n];
            int[] primes = new int[n];
            for (int i = 2; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    primes[index++] = i;
                }
                for (int j = 0; j < index && primes[j] * i < n; j++)
                {
                    nums[i * primes[j]] = 1;
                    if (i % primes[j] == 0)
                    {
                        break;
                    }
                }
            }
            return index;
        }
    }
}
