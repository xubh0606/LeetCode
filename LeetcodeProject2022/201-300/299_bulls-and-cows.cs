using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _299_bulls_and_cows
    {
        public string GetHint(string secret, string guess)
        {
            int bulls = 0;
            int cows = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < secret.Length; i++)
            {
                char num = secret[i];
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }
            for (int j = 0; j < secret.Length; j++)
            {
                char num = secret[j];
                char guessNum = guess[j];
                if (num == guessNum)
                {
                    bulls++;
                    if (dic[num] > 0)
                    {
                        dic[num]--;
                    }
                    else
                    {
                        cows--;
                    }
                }
                else if (dic.ContainsKey(guessNum))
                {
                    if (dic[guessNum] > 0)
                    {
                        dic[guessNum]--;
                        cows++;
                    }
                }
            }
            string res = $"{bulls}A{cows}B";
            return res;
        }
    }
}
