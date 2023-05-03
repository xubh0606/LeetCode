using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1599_MinOperationsMaxProfit
    {//解读题意
     //运上去就给钱
     //不付钱就不给转
     //很合理嘛
        public int MinOperationsMaxProfit(int[] customers, int boardingCost, int runningCost)
        {
            int max = 0;
            int cur_profit = 0;
            int restCustomers = 0;
            int count = 0;
            int res = -1;
            if (boardingCost * 4 <= runningCost)
            {
                return -1;
            }
            for (int i = 0; i < customers.Length; i++)
            {
                restCustomers += customers[i];
                if (restCustomers > 3)
                {
                    restCustomers -= 4;
                    count = 4;
                }
                else
                {
                    count = restCustomers;
                    restCustomers = 0;
                }
                cur_profit += count * boardingCost - runningCost;
                if (cur_profit > max)
                {
                    res = i;
                    max = cur_profit;
                }
            }
            int start = customers.Length;
            while (restCustomers != 0)
            {
                if (restCustomers > 3)
                {
                    restCustomers -= 4;
                    count = 4;
                }
                else
                {
                    count = restCustomers;
                    restCustomers = 0;
                }
                cur_profit += count * boardingCost - runningCost;
                if (cur_profit > max)
                {
                    res = start;
                    max = cur_profit;
                }
                start++;
            }
            if (res == -1)
            {
                return -1;
            }
            return res + 1;
        }
    }
}
