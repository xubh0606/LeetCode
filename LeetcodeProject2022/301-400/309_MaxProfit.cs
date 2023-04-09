using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _309_MaxProfit
    {
        //给定一个整数数组prices，其中第 prices[i] 表示第 i 天的股票价格
        //设计一个算法计算出最大利润
        //卖出股票后，你无法在第二天买入股票 (即冷冻期为 1 天)。
        public int MaxProfit(int[] prices)
        {
            int[,] dp = new int[prices.Length, 3];
            //0位置为未持有且未进入等待期
            dp[0, 0] = 0;
            //1位置为已经持有
            dp[0, 1] = -1 * prices[0];
            //2位置为未持有且进入等待期
            dp[0, 2] = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 2], dp[i - 1, 0]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i]);
                dp[i, 2] = dp[i - 1, 1] + prices[i];
            }
            return Math.Max(dp[prices.Length - 1, 0], dp[prices.Length - 1, 2]);
        }
    }
}
