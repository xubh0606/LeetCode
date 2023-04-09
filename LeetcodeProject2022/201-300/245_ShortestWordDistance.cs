using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _245_ShortestWordDistance
    {
        public int ShortestWordDistance(string[] wordsDict, string word1, string word2)
        {
            int min = int.MaxValue;
            int left = -1;
            int right = -1;
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1)
                {
                    left = i;
                    if (right != -1)
                    {
                        min = Math.Min(min, left - right);
                    }
                }
                if (wordsDict[i] == word2)
                {
                    right = i;
                    if (left == right)
                    {
                        continue;
                    }
                    if (left != -1)
                    {
                        min = Math.Min(min, right - left);
                    }
                }
            }
            return min;
        }
    }
}
