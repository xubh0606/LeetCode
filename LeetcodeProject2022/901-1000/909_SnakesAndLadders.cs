using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _909_SnakesAndLadders
    {
        public int SnakesAndLadders(int[][] board)
        {
            int n = board.Length;
            int totalSquare = n * n;
            HashSet<int> visited = new HashSet<int>();
            Queue<int> qSquare = new Queue<int>();
            qSquare.Enqueue(1);
            visited.Add(1);
            int count = 1;
            int step = 1;
            while (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int curSquare = qSquare.Dequeue();
                    for (int j = curSquare + 1; j < curSquare + 7; j++)
                    {
                        if (j == totalSquare)
                        {
                            return step;
                        }
                        int[] transJ = traslate(j, n);
                        int sl = board[transJ[0]][transJ[1]];
                        if (sl > 0)
                        {
                            if (sl == totalSquare)
                            {
                                return step;
                            }
                            if (!visited.Contains(sl))
                            {
                                qSquare.Enqueue(sl);
                                visited.Add(sl);
                            }
                        }
                        else
                        {
                            if (!visited.Contains(j))
                            {
                                qSquare.Enqueue(j);
                                visited.Add(j);
                            }
                        }
                    }
                }
                step++;
                count = qSquare.Count;
            }
            return -1;
        }
        int[] traslate(int num, int n)
        {
            int[] res = new int[2];
            int temp = (num - 1) / n;
            if (temp % 2 == 0)
            {
                res[1] = (num - 1) % n;
            }
            else
            {
                res[1] = n - (num - 1) % n - 1;
            }
            res[0] = n - 1 - temp;
            return res;
        }
    }
}
