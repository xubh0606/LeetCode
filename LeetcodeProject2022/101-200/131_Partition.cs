using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _131_Partition
    {
        string m_s;
        int m_len = 0;
        public IList<IList<string>> Partition(string s)
        {
            m_s = s;
            m_len = s.Length;
            IList<IList<string>> res = new List<IList<string>>();
            GetPalindromeListTrackBack(new StringBuilder(), new List<string>(), 0, res);
            return res;
        }
        void GetPalindromeListTrackBack(StringBuilder sb, IList<string> cur_list, int start, IList<IList<string>> res)
        {
            if (start == m_len)
            {
                res.Add(new List<string>(cur_list));
                return;
            }
            for (int i = start; i < m_len; i++)
            {
                sb.Append(m_s[i]);
                if (IsPalindrome(sb))
                {
                    cur_list.Add(sb.ToString());
                    GetPalindromeListTrackBack(new StringBuilder(), cur_list, i + 1, res);
                    cur_list.RemoveAt(cur_list.Count - 1);
                }
            }
        }
        bool IsPalindrome(StringBuilder sb)
        {
            int left = 0;
            int right = sb.Length - 1;
            while (left < right)
            {
                if (sb[left] != sb[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
