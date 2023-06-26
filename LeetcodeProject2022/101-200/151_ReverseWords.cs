using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _151_ReverseWords
    {
        public string ReverseWords(string s)
        {
            //先获取词，再组合
            string res = "";
            Stack<string> endWords = new Stack<string>();
            int left = 0;
            int right = s.Length;
            while (left < right && s[left] == ' ')
            {
                left++;
            }
            while (left < right)
            {
                //保证left停在字符进入端， right在结束端
                left = InsertLeft(endWords, left, s);
            }
            //此时如果left和right之间只有空格则为偶数个字符，否则需要多出栈一个
            if (endWords.Count == 0)
            {
                return res;
            }
            res = endWords.Pop();
            while (endWords.Count > 0)
            {
                res += ' ' + endWords.Pop();
            }
            return res;
        }
        int InsertLeft(Stack<string> endWords, int left, string s)
        {
            string str = "";
            while (left < s.Length && s[left] != ' ')
            {
                str += s[left];
                left++;
            }
            if (str == "")
            {
                return int.MaxValue;
            }
            endWords.Push(str);
            while (left < s.Length && s[left] == ' ')
            {
                left++;
            }
            return left;
        }
    }
}
