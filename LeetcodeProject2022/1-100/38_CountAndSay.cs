using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022Tests._1_100
{
    public class _38_CountAndSay
    {
        public string CountAndSay(int n)
        {
            string startS = "1";
            n--;
            while (n > 0)
            {
                startS = Count(startS);
                n--;
            }
            return startS;
        }
        string Count(string s)
        {
            int index = 0;
            string res = "";
            while (index < s.Length)
            {
                int count = 1;
                char lastC = s[index];
                index++;
                while (index < s.Length && s[index] == lastC)
                {
                    index++;
                    count++;
                }
                res += Convert.ToString(count) + lastC;
            }
            return res;
        }
    }
}
