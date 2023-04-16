using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _779_KthGrammar
    {
        public int KthGrammar(int n, int k)
        {
            int divider = 4;
            bool isDifferent = false;
            k--;
            while (k >= divider && divider < (1 << 30))
            {
                divider *= 4;
            }
            while (divider > 4)
            {
                divider /= 4;
                if (k >= divider)
                {
                    if (k / divider == 1 || k / divider == 2)
                    {
                        isDifferent = !isDifferent;
                    }
                    k %= divider;
                }
            }
            if (k == 1 || k == 2)
            {
                if (isDifferent)
                {
                    return 0;
                }
                return 1;
            }
            if (isDifferent)
            {
                return 1;
            }
            return 0;
        }
    }
}
