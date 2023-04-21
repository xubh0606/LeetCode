using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _30_FindSubstringSolution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            IList<int> res = new List<int>();
            int lenArr = words.Length;
            int lenOne = words[0].Length;
            int lenAll = lenOne * lenArr;
            int len = s.Length;
            for (int i = 0; i < lenArr; i++)
            {
                string word = words[i];
                if (dic.ContainsKey(word))
                {
                    dic[word]++;
                }
                else
                {
                    dic.Add(word, 1);
                }
            }
            for (int i = 0; i < lenOne; i++)
            {
                int curIndex = i;
                //起始点
                int left = i;
                //运行index
                int endIndex = i + lenAll;
                //终点
                int count = lenArr;
                Dictionary<string, int> newDic = new Dictionary<string, int>(dic);
                Queue<string> q = new Queue<string>();
                while (endIndex <= len)
                {
                    char[] word = new char[lenOne];
                    for (int j = 0; j < lenOne; j++)
                    {
                        word[j] = s[j + left];
                    }
                    string temp = new string(word);
                    if (newDic.ContainsKey(temp))
                    {
                        if (newDic[temp] <= 0)
                        {
                            string de = q.Dequeue();
                            newDic[de]++;
                            curIndex += lenOne;
                            //终点移动
                            while (de != temp)
                            {
                                de = q.Dequeue();
                                if (newDic[de] == 0)
                                {
                                    count++;
                                }
                                newDic[de]++;
                                curIndex += lenOne;
                            }
                            count--;
                            endIndex = curIndex + lenAll;
                        }
                        //出现不符合条件的string，跳过到终点重新开始
                        else
                        {
                            q.Enqueue(temp);
                            newDic[temp]--;
                            left += lenOne;
                            if (newDic[temp] == 0)
                            {
                                count--;
                            }
                            if (left == endIndex)
                            {
                                res.Add(curIndex);
                                curIndex += lenOne;
                                endIndex += lenOne;
                                string de = q.Dequeue();
                                newDic[de]++;
                                count++;
                            }
                        }
                    }
                    else
                    {
                        curIndex = left + lenOne;
                        left = curIndex;
                        endIndex = curIndex + lenAll;
                        newDic = new Dictionary<string, int>(dic);
                        count = lenArr;
                        q.Clear();
                    }
                }
            }
            return res;
        }
    }
}
