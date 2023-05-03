using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static bool IsSameTree(TreeNode root1, TreeNode root2)
        {
            if(root1 == null)
            {
                if(root2 != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if(root1.val != root2.val)
            {
                return false;
            }
            if(!IsSameTree(root1.left, root2.left))
            {
                return false;
            }
            if (!IsSameTree(root1.right, root2.right))
            {
                return false;
            }
            return true;
        }

        public static TreeNode GetTree(int[] arr)
        {
            if(arr.Length == 0)
            {
                return null;
            }
            TreeNode root = new TreeNode(arr[0]);
            IList<TreeNode> list = new List<TreeNode>();
            list.Add(root);
            int father = 0;
            bool isLeft = true;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == -1)
                {
                    list.Add(new TreeNode());
                    if (isLeft)
                    {
                        isLeft = false;
                    }
                    else
                    {
                        isLeft = true;
                        father++;
                    }
                    continue;
                }
                TreeNode new_node = new TreeNode(arr[i]);
                list.Add(new_node);
                if(isLeft)
                {
                    list[father].left = new_node;
                    isLeft = false;
                }
                else
                {
                    list[father].right = new_node;
                    isLeft = true;
                    father++;
                }
            }
            return root;
        }
    }
}
