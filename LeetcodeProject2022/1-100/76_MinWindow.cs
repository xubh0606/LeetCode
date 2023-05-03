using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _76_MinWindow
    {
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int n = t.Length;
            for (int i = 0; i < n; i++)
            {
                char c = t[i];
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }
            //创建全部字母的dic
            int minCount = int.MaxValue;
            int count = n;
            int start = 0;
            int end = 0;
            int resStart = 0;
            int resEnd = 0;
            while (end < s.Length)
            {
                //查找是否有符合的
                char temp = s[end];
                if (dic.ContainsKey(temp))
                {
                    dic[temp]--;
                    if (dic[temp] >= 0)
                    {
                        count--;
                        //如果已经达到目标，则收缩左侧保证最小的字符串
                        if (count == 0)
                        {
                            while (count == 0)
                            {
                                char p = s[start];
                                if (dic.ContainsKey(p))
                                {
                                    dic[p]++;
                                    if (dic[p] > 0)
                                    {
                                        count++;
                                        int curCount = end - start;
                                        //如果收缩结束比之前的结果小，则保存
                                        if (curCount < minCount)
                                        {
                                            minCount = curCount;
                                            resEnd = end;
                                            resStart = start;
                                        }
                                    }
                                }
                                start++;
                            }
                        }
                    }
                }
                end++;
            }
            if (minCount == int.MaxValue)
            {
                return "";
            }
            string res = "";
            for (int i = resStart; i <= resEnd; i++)
            {
                res += s[i];
            }
            return res;
        }
    }
}
