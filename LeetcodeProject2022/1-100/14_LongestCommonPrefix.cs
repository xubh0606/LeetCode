using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }
            ProfixNode head = new ProfixNode();
            int min = strs[0].Length;
            int first = 0;
            ProfixNode first_head = head;
            while (first < strs[0].Length)
            {
                int place = strs[0][first] - 'a';
                first_head.next[place] = new ProfixNode();
                first_head = first_head.next[place];
                first++;
            }
            for (int i = 1; i < strs.Length; i++)
            {
                int start = 0;
                ProfixNode cur_head = head;
                string s = strs[i];
                while (start < s.Length)
                {
                    int place = s[start] - 'a';
                    if (cur_head.next[place] == null)
                    {
                        break;
                    }
                    cur_head = cur_head.next[place];
                    start++;
                }
                min = Math.Min(min, start);
            }
            return strs[0].Substring(0, min);
        }
    }
    public class ProfixNode
    {
        public ProfixNode[] next;
        private int m_MaxCount = 26;
        public ProfixNode()
        {
            next = new ProfixNode[m_MaxCount];
        }
    }
}
