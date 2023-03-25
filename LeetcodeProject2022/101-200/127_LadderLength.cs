using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _127_LadderLength
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            int length = wordList.Count;
            int end = findEnd(endWord, wordList);
            if (end < 0)
            {
                return 0;
            }
            Queue<string> q = new Queue<string>();
            q.Enqueue(beginWord);
            int res = 1;
            while (q.Count != 0)
            {
                res++;
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    string temp = q.Dequeue();
                    for (int j = 0; j < wordList.Count; j++)
                    {
                        string str = wordList[j];
                        if (IsTransforable(temp, str))
                        {
                            if (j == end)
                            {
                                return res;
                            }
                            q.Enqueue(str);
                            wordList[j] = "";
                        }
                    }
                }
            }
            return 0;
        }

        int findEnd(string endWord, IList<string> wordList)
        {
            for (int i = 0; i < wordList.Count; i++)
            {
                if (endWord == wordList[i])
                {
                    return i;
                }
            }
            return -1;
        }

        bool IsTransforable(string str, string target)
        {
            int different = 0;
            if (target.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != target[i])
                {
                    different++;
                }
                if (different > 1)
                {
                    return false;
                }
            }
            if (different != 1)
            {
                return false;
            }
            return true;
        }
    }
}
