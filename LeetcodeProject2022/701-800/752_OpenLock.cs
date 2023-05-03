using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _752_OpenLock
    {
        HashSet<int> set = new HashSet<int>();
        bool canMeet = false;
        public int OpenLock(string[] deadends, string target)
        {
            if (target == "0000")
            {
                return 0;
            }
            int[] Rdeadends = new int[4];
            for (int j = 0; j < deadends.Length; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    Rdeadends[i] = (deadends[j][i]) - '0';
                }
                set.Add(Result(Rdeadends));
            }
            if (set.Contains(0))
            {
                return -1;
            }
            int[] t = new int[4];
            for (int i = 0; i < 4; i++)
            {
                t[i] = target[i] - '0';
            }
            return Bfs(t);
        }

        int Bfs(int[] target)
        {
            HashSet<int> dicS = new HashSet<int>();
            HashSet<int> dicT = new HashSet<int>();
            Queue<int[]> qS = new Queue<int[]>();
            Queue<int[]> qT = new Queue<int[]>();
            int res = 0;
            int[] s = new int[] { 0, 0, 0, 0 };
            dicS.Add(Result(s));
            dicT.Add(Result(target));
            qS.Enqueue(s);
            qT.Enqueue(target);
            while (qT.Count != 0 && qS.Count != 0)
            {
                if (qS.Count > qT.Count)
                {
                    update(qT, dicT, dicS);
                }
                else
                {
                    update(qS, dicS, dicT);
                }
                res++;
                if (canMeet)
                {
                    return res;
                }
            }


            return -1;
        }

        void update(Queue<int[]> q, HashSet<int> dicUsing, HashSet<int> dicTarget)
        {

            int count = q.Count;
            for (int i = 0; i < count; i++)
            {
                int[] arr = q.Dequeue();
                for (int k = 0; k < 4; k++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        int[] clone = (int[])arr.Clone();
                        clone[k] = sum(clone[k], j);
                        int hash = Result(clone);
                        if (dicUsing.Contains(hash) || set.Contains(hash))
                        {
                            continue;
                        }
                        else
                        {
                            if (dicTarget.Contains(hash))
                            {
                                canMeet = true;
                                return;
                            }
                            else
                            {
                                dicUsing.Add(hash);
                                q.Enqueue(clone);
                            }
                        }
                        j++;
                    }
                }
            }

        }

        int Result(int[] start)
        {
            int res = 0;
            for (int i = 0; i < 4; i++)
            {
                res = res * 10 + start[i];
            }
            return res;
        }

        int sum(int c, int i)
        {
            if (c == 0 && i == -1)
            {
                return 9;
            }
            if (c == 9 && i == 1)
            {
                return 0;
            }
            return c + i;
        }
    }
}
