using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
    public class _208_Trie
    {
        _208_PrefixNode m_head;
        public _208_Trie()
        {
            m_head = new _208_PrefixNode();
        }

        public void Insert(string word)
        {
            _208_PrefixNode head = m_head;
            for (int i = 0; i < word.Length; i++)
            {
                int cur = word[i] - 'a';
                if (head.arr[cur] == null)
                {
                    head.arr[cur] = new _208_PrefixNode();
                }
                head = head.arr[cur];
            }
            head.isEnd = true;
        }

        public bool Search(string word)
        {
            _208_PrefixNode head = m_head;
            for (int i = 0; i < word.Length; i++)
            {
                int cur = word[i] - 'a';
                if (head.arr[cur] == null)
                {
                    return false;
                }
                head = head.arr[cur];
            }
            return head.isEnd;
        }

        public bool StartsWith(string prefix)
        {
            _208_PrefixNode head = m_head;
            for (int i = 0; i < prefix.Length; i++)
            {
                int cur = prefix[i] - 'a';
                if (head.arr[cur] == null)
                {
                    return false;
                }
                head = head.arr[cur];
            }
            return true;
        }
    }
    public class _208_PrefixNode
    {
        public bool isEnd;
        public _208_PrefixNode[] arr;
        public _208_PrefixNode()
        {
            arr = new _208_PrefixNode[26];
            isEnd = false;
        }
    }
}
