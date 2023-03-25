using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _121_MaxProfit
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                }
                else
                {
                    int cur_profit = prices[i] - min;
                    if (profit < cur_profit)
                    {
                        profit = cur_profit;
                    }
                }
            }
            return profit;
        }
    }
}
