using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _383_CanConstruct
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] words = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                words[magazine[i] - 'a']++;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                int word = ransomNote[i] - 'a';
                if (words[word] == 0)
                {
                    return false;
                }
                words[word]--;
            }
            return true;
        }
    }
}
