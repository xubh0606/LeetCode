using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1103_DistributeCandies
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            int sum = num_people * (num_people + 1) / 2;
            int[] res = new int[num_people];
            int count = 0;
            if (sum < candies)
            {
                int oneTime = num_people * num_people;
                int total = oneTime + sum;
                count++;
                while (sum + total < candies)
                {
                    sum += total;
                    count++;
                    total += oneTime;
                }
                candies -= sum;
                for (int i = 0; i < num_people; i++)
                {
                    res[i] += ((i + 1) * 2 + (count - 1) * num_people) * count / 2;
                }
            }
            count++;
            int cur = 1 + (count - 1) * num_people;
            for (int i = 0; i < num_people; i++)
            {
                if (cur < candies)
                {
                    res[i] += cur;
                    candies -= cur;
                    cur++;
                }
                else
                {
                    res[i] += candies;
                    break;
                }
            }
            return res;
        }
    }
}
