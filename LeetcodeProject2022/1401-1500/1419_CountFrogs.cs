using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1419_CountFrogs
    {
        public int MinNumberOfFrogs(string croakOfFrogs)
        {
            int[] words = new int[5];
            int max = 0;
            for (int i = 0; i < croakOfFrogs.Length; i++)
            {
                int toAdd = -1;
                if (croakOfFrogs[i] == 'c')
                {
                    words[0]++;
                }
                if (croakOfFrogs[i] == 'r')
                {
                    toAdd = 1;
                }
                if (croakOfFrogs[i] == 'o')
                {
                    toAdd = 2;
                }
                if (croakOfFrogs[i] == 'a')
                {
                    toAdd = 3;
                }
                if (croakOfFrogs[i] == 'k')
                {
                    toAdd = 4;
                }
                if (toAdd > 0)
                {
                    if (words[toAdd] < words[toAdd - 1])
                    {
                        words[toAdd]++;
                        if (toAdd == 4)
                        {
                            max = Math.Max(max, words[0]);
                            for (int j = 0; j < 5; j++)
                            {
                                words[j]--;
                            }
                        }
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (words[i] != 0)
                {
                    return -1;
                }
            }
            return max;
        }
    }
}
