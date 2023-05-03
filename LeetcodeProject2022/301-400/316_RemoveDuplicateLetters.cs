using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _316_RemoveDuplicateLetters
    {
        public string RemoveDuplicateLetters(string s)
        {
            int[] numOfchar = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                numOfchar[s[i] - 'a']++;
            }
            bool[] isInStack = new bool[26];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                int cur_char = s[i] - 'a';
                numOfchar[cur_char]--;
                if (isInStack[cur_char])
                {
                    continue;
                }
                while (stack.Count != 0 && stack.Peek() > cur_char && numOfchar[stack.Peek()] != 0)
                {
                    isInStack[stack.Pop()] = false;

                }
                stack.Push(cur_char);
                isInStack[cur_char] = true;
            }
            StringBuilder sb = new StringBuilder();
            while (stack.Count != 0)
            {
                sb.Append((char)(stack.Pop() + 'a'));
            }
            string res = "";
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                res += sb[i];
            }
            return res;
        }
    }
}
