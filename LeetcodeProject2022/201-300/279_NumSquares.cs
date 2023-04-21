using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _279_NumSquares
    {
        int minCount = int.MaxValue;
        public int NumSquares(int n)
        {
            int i = 1;
            while (i * i < n)
            {
                i++;
            }
            if (i * i == n)
            {
                return 1;
            }
            i--;
            TryEveryPossible(n, i, 0);
            return minCount;
        }
        void TryEveryPossible(int n, int maxSquare, int count)
        {
            if (count >= minCount)
            {
                return;
            }
            for (int i = maxSquare; i > 0; i--)
            {
                if (n < i * i)
                {
                    continue;
                }
                if (n == i * i)
                {
                    minCount = count + 1;
                    return;
                }
                TryEveryPossible(n - i * i, i, count + 1);
            }
        }
    }
}
