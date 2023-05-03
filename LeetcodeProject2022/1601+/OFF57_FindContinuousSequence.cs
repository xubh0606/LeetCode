using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class OFF57_FindContinuousSequence
    {
        public int[][] FindContinuousSequence(int target)
        {
            int start = 1;
            int end = 2;
            int sum = 3;
            IList<int[]> res = new List<int[]>();
            LinkedList<int> seq = new LinkedList<int>();
            seq.AddLast(1);
            seq.AddLast(2);
            while (seq.Count > 1 && (start + end <= target))
            {
                if (sum == target)
                {
                    res.Add(seq.ToArray());
                    end++;
                    sum += end;
                    seq.AddLast(end);
                }
                else if (sum < target)
                {
                    end++;
                    sum += end;
                    seq.AddLast(end);
                }
                else
                {
                    sum -= start;
                    start++;
                    seq.RemoveFirst();
                }
            }
            return res.ToArray();
        }
    }
}
