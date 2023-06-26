using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _211_WordDictionary
    {
        //构造字典树
        //将字符串拆分成树状结构
        TireTreeNode m_head;
        public _211_WordDictionary()
        {
            m_head = new TireTreeNode();
        }

        public void AddWord(string word)
        {
            TireTreeNode cur_head = m_head;
            InsertNext(cur_head, word, 0);
        }

        //添加时每次找到对应字符的字母顺位
        //遇到特殊情况进入递归添加
        void InsertNext(TireTreeNode cur_head, string word, int index)
        {
            if (index == word.Length - 1)
            {
                if (word[index] == '.')
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (cur_head.next[i] == null)
                        {
                            cur_head.next[i] = new TireTreeNode();
                            cur_head.next[i].end = true;
                        }
                        else
                        {
                            cur_head.next[i].end = true;
                        }
                    }
                }
                else
                {
                    int place = word[index] - 'a';
                    if (cur_head.next[place] == null)
                    {
                        cur_head.next[place] = new TireTreeNode();
                        cur_head.next[place].end = true;
                    }
                    else
                    {
                        cur_head.next[place].end = true;
                    }
                }
            }
            else
            {
                if (word[index] == '.')
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (cur_head.next[i] == null)
                        {
                            cur_head.next[i] = new TireTreeNode();
                            InsertNext(cur_head.next[i], word, index + 1);
                        }
                        else
                        {
                            InsertNext(cur_head.next[i], word, index + 1);
                        }
                    }
                }
                else
                {
                    int place = word[index] - 'a';
                    if (cur_head.next[place] == null)
                    {
                        cur_head.next[place] = new TireTreeNode();
                        InsertNext(cur_head.next[place], word, index + 1);
                    }
                    else
                    {
                        InsertNext(cur_head.next[place], word, index + 1);
                    }
                }
            }
        }

        public bool Search(string word)
        {
            TireTreeNode cur_head = m_head;
            return FindNext(cur_head, word, 0);
        }

        //搜索时同理，每次根据字母对应位置搜索
        bool FindNext(TireTreeNode cur_head, string word, int index)
        {
            if (index == word.Length - 1)
            {
                if (word[index] == '.')
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (cur_head.next[i] == null)
                        {
                            continue;
                        }
                        else
                        {
                            if (cur_head.next[i].end)
                            {
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    int place = word[index] - 'a';
                    if (cur_head.next[place] == null)
                    {
                        return false;
                    }
                    else
                    {
                        if (cur_head.next[place].end)
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (word[index] == '.')
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (cur_head.next[i] == null)
                        {
                            continue;
                        }
                        else
                        {
                            if (FindNext(cur_head.next[i], word, index + 1))
                            {
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    int place = word[index] - 'a';
                    if (cur_head.next[place] == null)
                    {
                        return false;
                    }
                    else
                    {
                        if (FindNext(cur_head.next[place], word, index + 1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
    public class TireTreeNode
    {
        public TireTreeNode[] next;
        public bool end;
        public TireTreeNode()
        {
            next = new TireTreeNode[26];
            end = false;
        }
    }
}
