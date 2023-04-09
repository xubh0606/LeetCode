using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _322_CoinChange
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }
            HashSet<int> visited = new HashSet<int>();
            Queue<int> cur_amountQueue = new Queue<int>();
            cur_amountQueue.Enqueue(0);
            int countQ = 1;
            int count = 0;
            while (countQ > 0)
            {
                count++;
                for (int i = 0; i < countQ; i++)
                {
                    int cur_amount = cur_amountQueue.Dequeue();
                    for (int j = 0; j < coins.Length; j++)
                    {
                        int new_amount = cur_amount + coins[j];
                        if (!visited.Contains(new_amount))
                        {
                            if (new_amount == amount)
                            {
                                return count;
                            }
                            if (new_amount > amount)
                            {
                                continue;
                            }
                            visited.Add(new_amount);
                            cur_amountQueue.Enqueue(new_amount);
                        }
                    }
                }
                countQ = cur_amountQueue.Count;
            }
            return -1;
        }
    }
}
