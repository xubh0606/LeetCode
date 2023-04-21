using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _276_NumWays
    {
        //有 k 种颜色的涂料和一个包含 n 个栅栏柱的栅栏，请你按下述规则为栅栏设计涂色方案：
        //1 每个栅栏柱可以用其中 一种 颜色进行上色。
        //2 相邻的栅栏柱 最多连续两个 颜色相同。
        public int NumWays(int n, int k)
        {
            int[] oneColor = new int[2];//由于对任意颜色他们的结果是一样的，可以归纳成一个三元问题
            oneColor[0] = 1;//代表当颜色为此颜色且为第一个的可能数
            oneColor[1] = 0;//代表当颜色为此颜色且为第二个的可能数
            for (int i = 1; i < n; i++)
            {
                int[] new_case = new int[2];
                new_case[1] = oneColor[0];
                new_case[0] = (oneColor[0] + oneColor[1]) * (k - 1);
                oneColor = new_case;
            }
            return (oneColor[1] + oneColor[0]) * k;
        }
    }
}
