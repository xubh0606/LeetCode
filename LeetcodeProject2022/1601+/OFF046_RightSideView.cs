using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class OFF046_RightSideView
    {
        //二叉树右视图
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> rightSideView = new List<int>();
            if (root == null)
            {
                return rightSideView;
            }
            Queue<TreeNode> treeInLevel = new Queue<TreeNode>();
            treeInLevel.Enqueue(root);
            while (treeInLevel.Count != 0)
            {
                int c = treeInLevel.Count - 1;
                for (int i = 0; i < c; i++)
                {
                    TreeNode father = treeInLevel.Dequeue();
                    if (father.left != null)
                    {
                        treeInLevel.Enqueue(father.left);
                    }
                    if (father.right != null)
                    {
                        treeInLevel.Enqueue(father.right);
                    }
                }
                TreeNode endFather = treeInLevel.Dequeue();
                rightSideView.Add(endFather.val);
                if (endFather.left != null)
                {
                    treeInLevel.Enqueue(endFather.left);
                }
                if (endFather.right != null)
                {
                    treeInLevel.Enqueue(endFather.right);
                }
            }
            return rightSideView;
        }
    }
}
