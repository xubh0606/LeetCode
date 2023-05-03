using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1553_MinDays
    {
        public int MinDays(int n)
        {
            Queue<Tuple<int, int>> leftCount = new Queue<Tuple<int, int>>();
            HashSet<int> visited = new HashSet<int>();
            int getThree = n % 3;
            int getTwo = n % 2;
            leftCount.Enqueue(new Tuple<int, int>(n / 3, getThree));
            leftCount.Enqueue(new Tuple<int, int>(n / 2, getTwo));
            int total = 0;
            while (leftCount.Count > 0)
            {
                int count = leftCount.Count;
                for (int i = 0; i < count; i++)
                {
                    Tuple<int, int> cur = leftCount.Dequeue();
                    if (cur.Item2 != 0)
                    {
                        leftCount.Enqueue(new Tuple<int, int>(cur.Item1, cur.Item2 - 1));
                    }
                    else
                    {
                        if (cur.Item1 == 0)
                        {
                            return total;
                        }
                        visited.Add(cur.Item1);
                        getThree = cur.Item1 % 3;
                        getTwo = cur.Item1 % 2;
                        int new_num1 = cur.Item1 / 3;
                        int new_num2 = cur.Item1 / 2;
                        if (!visited.Contains(new_num1))
                        {
                            leftCount.Enqueue(new Tuple<int, int>(new_num1, getThree));
                        }
                        if (!visited.Contains(new_num2))
                        {
                            leftCount.Enqueue(new Tuple<int, int>(new_num2, getTwo));
                        }
                    }
                }
                total++;
            }
            return -1;
        }
    }
}
