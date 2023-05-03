using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1542_LongestAwesome
    {
        //构造10位的hash，然后对奇偶性质进行调整，每次改动时形成对应数字位的奇偶性转变
        //计算是否为最大时只需要找改变一位以内的是否存在，所以变化次数为10，就可以得到结果了
        public int LongestAwesome(string s)
        {
            //建立hash，存储目标为10以内的奇偶位置
            Dictionary<int, int> numSet = new Dictionary<int, int>();
            int cur = 0;//一开始所有位置全是0
            int max = 0;//取最大位置
            numSet.Add(0, -1);
            for (int i = 0; i < s.Length; i++)
            {
                cur ^= (1 << (s[i] - '0'));//当前值作为右侧,哪怕曾经有过也不影响此时最远
                if (numSet.ContainsKey(cur))
                {
                    max = Math.Max(max, i - numSet[cur]);
                    //同样时也可能最远，虽然可能性很小但是存在，比如全部数字都为0！
                }
                else
                {
                    numSet.Add(cur, i);//只在第一次时记录位置保证最远
                }
                for (int j = 0; j < 10; j++)
                {
                    int possibleLeft = cur ^ (1 << j);//单次任何数位改变时都可以作为左侧
                    if (numSet.ContainsKey(possibleLeft))
                    {
                        max = Math.Max(max, i - numSet[possibleLeft]);
                    }
                }
            }
            return max;
        }
    }
}
