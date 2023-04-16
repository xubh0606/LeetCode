using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _781_NumRabbits
    {
        public int NumRabbits(int[] answers)
        {
            Dictionary<int, int> rabbits = new Dictionary<int, int>();
            int res = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (rabbits.ContainsKey(answers[i]))
                {
                    rabbits[answers[i]]++;
                    if (rabbits[answers[i]] == answers[i] + 2)
                    {
                        res += answers[i] + 1;
                        rabbits[answers[i]] = 1;
                    }
                }
                else
                {
                    rabbits.Add(answers[i], 1);
                    res += answers[i] + 1;
                }
            }
            return res;
        }
    }
}
