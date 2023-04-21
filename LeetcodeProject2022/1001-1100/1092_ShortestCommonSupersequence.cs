using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1092_ShortestCommonSupersequence
    {
        public string ShortestCommonSupersequence(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int[,] dp = new int[len1 + 1, len2 + 1];//找最大公共子序列
            for (int i = 1; i <= len1; i++)
            {
                for (int j = 1; j <= len2; j++)
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - 1] + 1);
                    }
                }
            }
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            Dfs(dp, set1, set2, len1, len2);
            int a = 1;
            int b = 1;
            string res = "";
            while (a <= len1 && b <= len2)
            {
                while (a <= len1 && (!set1.Contains(a)))
                {
                    res += str1[a - 1];
                    a++;
                }
                while (b <= len2 && (!set2.Contains(b)))
                {
                    res += str2[b - 1];
                    b++;
                }
                if (a <= len1 && b <= len2)
                {
                    res += str1[a - 1];
                    a++;
                    b++;
                }
            }
            while (a <= len1)
            {
                res += str1[a - 1];
                a++;
            }
            while (b <= len2)
            {
                res += str2[b - 1];
                b++;
            }
            return res;
        }
        void Dfs(int[,] dp, HashSet<int> s1, HashSet<int> s2, int a, int b)
        {
            if (dp[a, b] == 0)
            {
                return;
            }
            int a1 = a - 1;
            int b1 = b - 1;
            if (dp[a1, b] == dp[a, b])
            {
                Dfs(dp, s1, s2, a1, b);
            }
            else if (dp[a, b1] == dp[a, b])
            {
                Dfs(dp, s1, s2, a, b1);
            }
            else
            {
                s1.Add(a);
                s2.Add(b);
                Dfs(dp, s1, s2, a1, b1);
            }
        }
    }
}
