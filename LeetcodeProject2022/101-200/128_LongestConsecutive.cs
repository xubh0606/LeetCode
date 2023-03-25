using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _128_LongestConsecutive
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        IList<int> list = new List<int>();
        int count = -1;
        public int LongestConsecutive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (dic.ContainsKey(num))
                {
                    continue;
                }
                else if (dic.ContainsKey(num + 1))
                {
                    int place = dic[num + 1];
                    dic.Add(num, place);
                    list[place]++;
                    if (dic.ContainsKey(num - 1))
                    {
                        union(num);
                    }
                }
                else if (dic.ContainsKey(num - 1))
                {
                    int place = dic[num - 1];
                    dic.Add(num, place);
                    list[place]++;
                }
                else
                {
                    count++;
                    list.Add(1);
                    dic.Add(num, count);
                }
            }
            int max = 0;
            for (int j = 0; j < list.Count; j++)
            {
                max = Math.Max(list[j], max);
            }
            return max;
        }
        void union(int num)
        {
            int i = num - 1;
            int value = dic[num + 1];
            while (dic.ContainsKey(i))
            {
                dic[i] = value;
                list[value]++;
                i--;
            }
        }
    }
}
