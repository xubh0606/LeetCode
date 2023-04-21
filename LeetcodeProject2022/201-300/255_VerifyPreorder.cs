using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _255_VerifyPreorder
    {
        public bool VerifyPreorder(int[] preorder)
        {
            Stack<int> stack = new Stack<int>();
            int i = 0;
            int max = 0;
            while (i < preorder.Length)
            {
                if (stack.Count == 0 || preorder[i] < stack.Peek())
                {
                    if(max > preorder[i])
                    {
                        return false;
                    }
                    stack.Push(preorder[i]);
                    i++;
                }
                else
                {
                    while(stack.Count > 0 && stack.Peek() < preorder[i])
                    {
                        max = stack.Pop();
                    }
                }
            }
            return true;
        }
    }
}
