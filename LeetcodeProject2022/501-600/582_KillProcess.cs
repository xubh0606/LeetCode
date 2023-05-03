using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _582_KillProcess
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            Dictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
            IList<int> res = new List<int>();
            for (int i = 0; i < pid.Count; i++)
            {
                int pp = ppid[i];
                int p = pid[i];
                if (dic.ContainsKey(pp))
                {
                    dic[pp].Add(p);
                }
                else
                {
                    dic.Add(pp, new List<int>());
                    dic[pp].Add(p);
                }
            }
            Queue<int> q = new Queue<int>();
            q.Enqueue(kill);
            while (q.Count != 0)
            {
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    int dq = q.Dequeue();
                    res.Add(dq);
                    if (dic.ContainsKey(dq))
                    {
                        IList<int> list = dic[dq];
                        for (int j = 0; j < list.Count; j++)
                        {
                            int temp = list[j];
                            q.Enqueue(temp);
                        }
                    }
                }
            }
            return res;
        }
    }
}
