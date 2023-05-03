using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1475_FinalPrices
    {
        public int[] FinalPrices(int[] prices)
        {
            Stack<int> pricesWait = new Stack<int>();
            for (int i = 0; i < prices.Length; i++)
            {
                //递增时直接加；否则排出大于当前值并重置价格，再加。
                while (pricesWait.Count != 0 && prices[i] <= prices[pricesWait.Peek()])
                {
                    int place = pricesWait.Pop();
                    prices[place] -= prices[i];
                }
                pricesWait.Push(i);
            }
            return prices;
        }
    }
}
