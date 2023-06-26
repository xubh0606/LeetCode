using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _5_LongestPalindrome
    {
        int m_len;
        public string LongestPalindrome(string s)
        {
            //建立中心点和半径的二维矩阵
            int r = s.Length;
            int max = 1;
            int index = 1;
            string new_s = "#";
            for (int i = 0; i < r; i++)
            {
                new_s += s[i];
                new_s += '#';
            }
            m_len = r * 2 + 1;
            int[] maxR = new int[m_len];//对应位置的已知最大半径
                                        //遍历字符串
            for (int i = 1; i < m_len - 1; i++)
            {
                //首先提取已知最大半径
                int cur_r = maxR[i];
                //放入s中进行开阔，如果可以扩大则更改visited和maxR
                int new_r = Expand(cur_r, new_s, i);
                //如果没扩大则不需理会，否则进行后续更改
                if (new_r != cur_r)
                {
                    //对左侧信息进行提取，对称地更改右侧信息
                    if (new_r > max || (max == 1 && new_r == 1 && new_s[i] == '#'))
                    {
                        max = new_r;
                        index = i;
                    }
                    Update(i, new_r, maxR);
                }
            }
            if (max == 1 && new_s[index] != '#')
            {
                return s[0].ToString();
            }
            return GetString(index, new_s, max);
        }
        int Expand(int r, string s, int index)
        {
            int left = index - r - 1;
            int right = index + r + 1;
            while (left >= 0 && right < m_len)
            {
                if (s[left] != s[right])
                {
                    break;
                }
                r++;
                left--;
                right++;
            }
            return r;
        }
        void Update(int index, int r, int[] maxR)
        {
            maxR[index] = r;
            int left = index - 1;
            int right = index + 1;
            int cur_r = r - 1;
            while (left >= 0 && right < m_len && cur_r > 0)
            {
                maxR[right] = Math.Min(maxR[left], cur_r);
                left--;
                right++;
                cur_r--;
            }
        }
        string GetString(int index, string s, int r)
        {
            string str = "";
            for (int i = index - r; i < index + r + 1; i++)
            {
                if (s[i] != '#')
                {
                    str += s[i];
                }
            }
            return str;
        }
    }
}
