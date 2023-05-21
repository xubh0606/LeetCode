using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1804_Trie
    {
        _1804_ProfixNode m_head;
        public _1804_Trie()
        {
            m_head = new _1804_ProfixNode();
        }

        public void Insert(string word)
        {
            _1804_ProfixNode cur_head = m_head;
            for (int i = 0; i < word.Length; i++)
            {
                int place = word[i] - 'a';
                if (cur_head.next[place] == null)
                {
                    cur_head.next[place] = new _1804_ProfixNode();
                    cur_head = cur_head.next[place];
                }
                else
                {
                    cur_head = cur_head.next[place];
                    cur_head.val++;
                }
            }
            cur_head.end++;
        }

        public int CountWordsEqualTo(string word)
        {
            _1804_ProfixNode cur_head = m_head;
            for (int i = 0; i < word.Length; i++)
            {
                int place = word[i] - 'a';
                if (cur_head.next[place] == null)
                {
                    return 0;
                }
                else
                {
                    cur_head = cur_head.next[place];
                }
            }
            return cur_head.end;
        }

        public int CountWordsStartingWith(string prefix)
        {
            _1804_ProfixNode cur_head = m_head;
            for (int i = 0; i < prefix.Length; i++)
            {
                int place = prefix[i] - 'a';
                if (cur_head.next[place] == null)
                {
                    return 0;
                }
                else
                {
                    cur_head = cur_head.next[place];
                }
            }
            return cur_head.val;
        }

        public void Erase(string word)
        {
            _1804_ProfixNode cur_head = m_head;
            for (int i = 0; i < word.Length; i++)
            {
                int place = word[i] - 'a';
                cur_head.next[place].val--;
                if (cur_head.next[place].val == 0)
                {
                    cur_head.next[place] = null;
                    return;
                }
                cur_head = cur_head.next[place];
            }
            cur_head.end--;
        }
    }
    public class _1804_ProfixNode
    {
        public int end;
        public int val;
        public _1804_ProfixNode[] next;

        public _1804_ProfixNode()
        {
            this.end = 0;
            this.val = 1;
            next = new _1804_ProfixNode[26];
        }
    }
}
