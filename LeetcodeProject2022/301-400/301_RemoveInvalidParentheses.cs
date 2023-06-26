using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _301_RemoveInvalidParentheses
    {
        //定义一个左括号当前剩余值，保证它非负
        public IList<string> RemoveInvalidParentheses(string s)
        {
            //先确定左括号需要删除还是右括号
            int len = s.Length;
            int totalLeft = 0;
            int totalRight = 0;
            int[] matched = new int[len];
            int remain = 0;
            for (int i = 0; i < len; i++)
            {
                if (i > 0)
                {
                    matched[i] = matched[i - 1];
                }
                if (s[i] == '(')
                {
                    totalLeft++;
                    remain++;
                }
                else if (s[i] == ')')
                {
                    totalRight++;
                    if (remain > 0)
                    {
                        remain--;
                        matched[i]++;
                    }
                }
            }
            Queue<int> remainingLeft = new Queue<int>();//已存在的未配对左括号数量
            Queue<int> remainingRight = new Queue<int>();//未参与配对的右括号数量
            Queue<string> strQueue = new Queue<string>();
            Queue<int> matchSet = new Queue<int>();//当前配对情况
            remainingLeft.Enqueue(0);
            strQueue.Enqueue("");
            remainingRight.Enqueue(totalRight);
            matchSet.Enqueue(0);
            //运动中的原则：1 必须使得达到右侧合并时满足匹配总数量
            //2 左括号存量不能超过右括号的存量
            for (int i = 0; i < len; i++)
            {
                if (s[i] == ')')
                {
                    int c = strQueue.Count;
                    for (int j = 0; j < c; j++)
                    {
                        string str = strQueue.Dequeue();
                        int left = remainingLeft.Dequeue();
                        int right = remainingRight.Dequeue();
                        int match = matchSet.Dequeue();
                        if (match + left < matched[i])
                        {
                            continue;
                        }
                        if (matched[i] > match)
                        {
                            remainingLeft.Enqueue(left - 1);
                            remainingRight.Enqueue(right - 1);
                            strQueue.Enqueue(str + ')');
                            matchSet.Enqueue(match + 1);
                        }
                        if (right >= matched[len - 1] - match)
                        {
                            remainingLeft.Enqueue(left);
                            remainingRight.Enqueue(right - 1);
                            strQueue.Enqueue(str);
                            matchSet.Enqueue(match);
                        }
                    }

                }
                else if (s[i] == '(')
                {
                    int c = strQueue.Count;
                    for (int j = 0; j < c; j++)
                    {
                        string str = strQueue.Dequeue();
                        int left = remainingLeft.Dequeue();
                        int right = remainingRight.Dequeue();
                        int match = matchSet.Dequeue();
                        strQueue.Enqueue(str + '(');
                        remainingLeft.Enqueue(left + 1);
                        remainingRight.Enqueue(right);
                        matchSet.Enqueue(match);
                        strQueue.Enqueue(str);
                        remainingLeft.Enqueue(left);
                        remainingRight.Enqueue(right);
                        matchSet.Enqueue(match);
                    }
                }
                else
                {
                    int c = strQueue.Count;
                    for (int j = 0; j < c; j++)
                    {
                        string str = strQueue.Dequeue();
                        strQueue.Enqueue(str + s[i]);
                    }
                }
            }
            IList<string> res = new List<string>();
            string sure = strQueue.Dequeue();
            int r = remainingLeft.Dequeue();
            if (r > 0)
            {
                int index = sure.Length - 1;
                while (r > 0)
                {
                    if (sure[index] == '(')
                    {
                        r--;
                        sure = sure.Remove(index, 1);
                    }
                    index--;
                }
            }
            int resultLen = sure.Length;
            res.Add(sure);
            HashSet<string> visited = new HashSet<string>();
            visited.Add(sure);
            while (strQueue.Count > 0)
            {
                string str = strQueue.Dequeue();
                r = remainingLeft.Dequeue();
                if (str.Length == resultLen && r == 0 && (!visited.Contains(str)))
                {
                    res.Add(str);
                    visited.Add(str);
                }
            }
            return res;
        }
    }
}
