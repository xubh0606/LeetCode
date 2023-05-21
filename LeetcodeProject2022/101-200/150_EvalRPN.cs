using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _150_EvalRPN
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> valStack = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+")
                {
                    valStack.Push(valStack.Pop() + valStack.Pop());
                }
                else if (tokens[i] == "-")
                {
                    int p1 = valStack.Pop();
                    int p2 = valStack.Pop();
                    valStack.Push(p2 - p1);
                }
                else if (tokens[i] == "*")
                {
                    valStack.Push(valStack.Pop() * valStack.Pop());
                }
                else if (tokens[i] == "/")
                {
                    int p1 = valStack.Pop();
                    int p2 = valStack.Pop();
                    valStack.Push(p2 / p1);
                }
                else
                {
                    valStack.Push(int.Parse(tokens[i]));
                }
            }
            return valStack.Pop();
        }
    }
}
