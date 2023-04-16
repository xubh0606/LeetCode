using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1002_CommonChars
    {
        public IList<string> CommonChars(string[] words)
        {
            int[] counts = new int[26];
            for (int i = 0; i < 26; i++)
            {
                counts[i] = int.MaxValue;
            }
            IList<string> res = new List<string>();
            if (words.Length == 0)
            {
                return res;
            }
            for (int i = 0; i < words.Length; i++)
            {
                int[] exist = new int[26];
                for (int j = 0; j < words[i].Length; j++)
                {
                    exist[words[i][j] - 'a']++;
                }
                for (int j = 0; j < 26; j++)
                {
                    counts[j] = Math.Min(counts[j], exist[j]);
                }
            }
            for (int i = 0; i < 26; i++)
            {
                string s = ((char)('a' + i)).ToString();
                while (counts[i] > 0)
                {
                    res.Add(s);
                    counts[i]--;
                }
            }
            return res;
        }
    }
}
