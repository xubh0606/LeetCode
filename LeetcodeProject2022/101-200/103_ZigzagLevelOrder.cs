using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022._101_200
{
    public class _103_ZigzagLevelOrder
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }
            Stack<TreeNode> st = new Stack<TreeNode>();
            st.Push(root);
            bool b = true;
            while (st.Count != 0)
            {
                IList<int> list = new List<int>();
                Stack<TreeNode> st1 = new Stack<TreeNode>();
                int n = st.Count;
                if (b)
                {
                    b = false;
                    for (int i = 0; i < n; i++)
                    {
                        TreeNode temp = st.Pop();
                        list.Add(temp.val);
                        if (temp.left != null)
                        {
                            st1.Push(temp.left);
                        }
                        if (temp.right != null)
                        {
                            st1.Push(temp.right);
                        }
                    }
                }
                else
                {
                    b = true;
                    for (int i = 0; i < n; i++)
                    {
                        TreeNode temp = st.Pop();
                        list.Add(temp.val);
                        if (temp.right != null)
                        {
                            st1.Push(temp.right);
                        }
                        if (temp.left != null)
                        {
                            st1.Push(temp.left);
                        }
                    }
                }
                st = st1;
                res.Add(list);
            }
            return res;
        }
    }
}
