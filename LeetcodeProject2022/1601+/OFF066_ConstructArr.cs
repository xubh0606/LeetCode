using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class OFF066_ConstructArr
    {
        public int[] ConstructArr(int[] a)
        {
            int len = a.Length;
            if (len == 0)
            {
                return a;
            }
            int[] leftMul = new int[len];
            int[] rightMul = new int[len];
            leftMul[0] = a[0];
            rightMul[len - 1] = a[len - 1];
            for (int i = 1; i < len - 1; i++)
            {
                leftMul[i] = leftMul[i - 1] * a[i];
            }
            for (int i = len - 2; i > 0; i--)
            {
                rightMul[i] = rightMul[i + 1] * a[i];
            }
            a[0] = rightMul[1];
            a[len - 1] = leftMul[len - 2];
            for (int i = 1; i < len - 1; i++)
            {
                a[i] = leftMul[i - 1] * rightMul[i + 1];
            }
            return a;
        }
    }
}
