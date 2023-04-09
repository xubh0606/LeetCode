using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _338_CountBits
    {
        public int[] CountBits(int n)
        {
            int[] res = new int[n + 1];
            int[] num = new int[18];
            res[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                int remain = 1;
                int strat = 0;
                int cur = res[i - 1];
                while (remain == 1)
                {
                    if (num[strat] == 1)
                    {
                        cur--;
                        num[strat] = 0;
                        strat++;
                    }
                    else
                    {
                        cur++;
                        num[strat] = 1;
                        remain = 0;
                    }
                }
                res[i] = cur;
            }
            return res;
        }
    }
}
