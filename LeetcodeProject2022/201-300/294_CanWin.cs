using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _294_CanWin
    {
        public bool CanWin(string currentState)
        {
            char[] arrC = new char[currentState.Length];
            for (int i = 0; i < currentState.Length - 1; i++)
            {
                if (currentState[i] == '+' && currentState[i + 1] == '+')
                {
                    arrC[i] = '-';
                    arrC[i + 1] = '-';
                    if (!CanWin(new string(arrC)))
                    {
                        return true;
                    }
                    arrC[i] = '+';
                    arrC[i + 1] = '+';
                }
            }
            return false;
        }
    }
}
