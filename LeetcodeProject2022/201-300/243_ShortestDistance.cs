using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _243_ShortestDistance
    {
        public int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            int place1 = -1;
            int place2 = -1;
            int min = int.MaxValue;
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1)
                {
                    place1 = i;
                    if (place2 != -1)
                    {
                        min = Math.Min(place1 - place2, min);
                    }
                }
                else if (wordsDict[i] == word2)
                {
                    place2 = i;
                    if (place1 != -1)
                    {
                        min = Math.Min(place2 - place1, min);
                    }
                }
            }
            return min;
        }
    }
}
