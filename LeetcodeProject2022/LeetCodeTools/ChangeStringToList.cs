using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022
{
    public class ChangeStringToList
    {
        //Change to IList<int>
        public IList<int> GetIListForInt(string s)
        {
            int num = 0;
            IList<int> list = new List<int>();
            for(int i= 0; i < s.Length; i++)
            {
                if(s[i] - '0' >= 0 && s[i]-'0' < 10)
                {
                    num = num * 10 + s[i] - '0';
                }
                else
                {
                    if(num > 0)
                    {
                        list.Add(num);
                    }
                    num = 0;
                }
            }
            return list;
        }
        //Change to IList<IList<int>>
        public IList<IList<int>> GetIListIListForInt(string s)
        {
            int num = 0;
            int count = -1;
            int start = 0;
            IList<IList<int>> bigList = new List<IList<int>>();
            while(start < s.Length)
            {
                if(s[start] == '[')
                {
                    if(count < 0)
                    {
                        count++;
                        continue;
                    }
                    start++;
                    IList<int> list = new List<int>();
                    bool changed = false;
                    for (int i = start; i < s.Length; i++)
                    {
                        start++;
                        if (s[i] - '0' >= 0 && s[i] - '0' < 10)
                        {
                            num = num * 10 + s[i] - '0';
                            changed = true;
                        }
                        else
                        {
                            if (changed)
                            {
                                list.Add(num);
                                changed = false;
                            }
                            num = 0;
                            if(s[i] == ']')
                            {
                                break;
                            }
                        }
                    }
                    bigList.Add(list);
                }
                start++;
            }
            return bigList;
        }
        
        public int[][] GetArrOfArrForInt(string s)
        {
            int num = 0;
            int count = -1;
            int start = 0;
            IList<IList<int>> bigList = new List<IList<int>>();
            while (start < s.Length)
            {
                if (s[start] == '[')
                {
                    if (count < 0)
                    {
                        start++;
                        count++;
                        continue;
                    }
                    start++;
                    IList<int> list = new List<int>();
                    bool changed = false;
                    for (int i = start; i < s.Length; i++)
                    {
                        start++;
                        if (s[i] - '0' >= 0 && s[i] - '0' < 10)
                        {
                            num = num * 10 + s[i] - '0';
                            changed = true;
                        }
                        else
                        {
                            if (changed)
                            {
                                list.Add(num);
                                changed = false;
                            }
                            num = 0;
                            if (s[i] == ']')
                            {
                                break;
                            }
                        }
                    }
                    bigList.Add(list);
                }
                start++;
            }
            int[][] res = new int[bigList.Count][];
            for(int i = 0; i < bigList.Count; i++)
            {
                res[i] = bigList[i].ToArray();
            }
            return res;
        }
    }
}
