using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _345_ReverseVowels
    {
        //反转字符串中的元音字母
        public string ReverseVowels(string s)
        {
            string vowels = "aeiouAEIOU";
            char[] arr = s.ToArray();
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < vowels.Length; i++)
            {
                set.Add(vowels[i]);
            }
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (!set.Contains(arr[left]))
                {
                    left++;
                    continue;
                }
                if (!set.Contains(arr[right]))
                {
                    right--;
                    continue;
                }
                Swap(arr, left, right);
                left++;
                right--;
            }
            return new string(arr);
        }
        void Swap(char[] s, int a, int b)
        {
            char temp = s[a];
            s[a] = s[b];
            s[b] = temp;
        }
    }
}
