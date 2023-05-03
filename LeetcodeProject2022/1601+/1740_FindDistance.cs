using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _1740_FindDistance
    {
        public int FindDistance(TreeNode root, int p, int q)
        {
            Stack<TreeNode> stackP = new Stack<TreeNode>();
            Stack<TreeNode> stackQ = new Stack<TreeNode>();
            FindEachNum(root, p, stackP);
            FindEachNum(root, q, stackQ);
            int pCount = stackP.Count;
            int qCount = stackQ.Count;
            int count = pCount - qCount;
            if (count > 0)
            {
                while (count > 0)
                {
                    stackP.Pop();
                    count--;
                }
            }
            else
            {
                while (count < 0)
                {
                    stackQ.Pop();
                    count++;
                }
            }
            count = stackQ.Count;
            while (true)
            {
                if (stackQ.Pop() == stackP.Pop())
                {
                    break;
                }
            }
            return pCount + qCount - stackP.Count * 2 - 2;
        }

        bool FindEachNum(TreeNode root, int num, Stack<TreeNode> stack)
        {
            stack.Push(root);
            if (root.val == num)
            {
                return true;
            }
            if (root.left != null)
            {
                if (FindEachNum(root.left, num, stack))
                {
                    return true;
                }
            }
            if (root.right != null)
            {
                if (FindEachNum(root.right, num, stack))
                {
                    return true;
                }
            }
            stack.Pop();
            return false;
        }
    }
}
