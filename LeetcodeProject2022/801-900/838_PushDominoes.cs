using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _838_PushDominoes
    {
        public string PushDominoes(string dominoes)
        {
            char[] new_dominoes = dominoes.ToArray();
            HashSet<int> changing = new HashSet<int>();
            int n = dominoes.Length;
            for (int i = 0; i < n; i++)
            {
                if (dominoes[i] != '.')
                {
                    changing.Add(i);
                }
            }
            while (changing.Count != 0)
            {
                IList<int> list = changing.ToList();
                IList<int> toChangeL = new List<int>();
                IList<int> toChangeR = new List<int>();
                IList<int> toRemove = new List<int>();
                foreach (int place in list)
                {
                    if (new_dominoes[place] == 'L')
                    {
                        if (place > 0)
                        {
                            if (new_dominoes[place - 1] == '.')
                            {
                                if (place > 1 && new_dominoes[place - 2] == 'R')
                                {
                                    toRemove.Add(place - 2);
                                }
                                else
                                {
                                    toChangeL.Add(place - 1);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (place < n - 1)
                        {
                            if (new_dominoes[place + 1] == '.')
                            {
                                if (place < n - 2 && new_dominoes[place + 2] == 'L')
                                {
                                    toRemove.Add(place + 2);
                                }
                                else
                                {
                                    toChangeR.Add(place + 1);
                                }
                            }
                        }
                    }
                    toRemove.Add(place);
                }
                foreach (int change in toChangeL)
                {
                    changing.Add(change);
                    new_dominoes[change] = 'L';
                }
                foreach (int change in toChangeR)
                {
                    changing.Add(change);
                    new_dominoes[change] = 'R';
                }
                foreach (int change in toRemove)
                {
                    changing.Remove(change);
                }
            }
            return new string(new_dominoes);
        }
    }
}
