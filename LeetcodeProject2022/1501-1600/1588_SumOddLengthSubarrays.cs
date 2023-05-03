using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1588_SumOddLengthSubarrays
    {//另一个思路是建立前缀和之后通过每层的总数字求和也是O(n)
        public int SumOddLengthSubarrays(int[] arr)
        {
            int total = 0;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                total += arr[i];
                int rest = i % 2;
                    int leftOddCount = i / 2;
                    int leftEvenCount = (i + rest) / 2;
                    int rightOddCount = (len - i - rest) / 2;
                    int rightEvenCount = (len - i) / 2;
                    total += (leftOddCount * rightOddCount + leftEvenCount * rightEvenCount) * arr[i];
                total += (rest == 0 ? leftOddCount+rightOddCount:rightEvenCount+leftEvenCount) * arr[i];
            }

            //for (int i = 0; i < len; i++)
            //{
            //    total += arr[i];
            //    int rest = i % 2;
            //    if (rest == 0)
            //    {
            //        int leftOddCount = i / 2;
            //        int rightOddCount = (len - i) / 2;
            //        int rightEvenCount = (len - i -1) / 2;
            //    }
            //    else
            //    {
            //        int leftOddCount = i / 2;
            //        int leftEvenCount = (i + 1) / 2;
            //        int rightOddCount = (len - i - 1) / 2;
            //        int rightEvenCount = (len - i) / 2;
            //    }
            //}
            return total;
        }
    }
}
