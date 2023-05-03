using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _1660_CorrectBinaryTree
    {
        public TreeNode CorrectBinaryTree(TreeNode root)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            IList<TreeNode> upNodeList = new List<TreeNode>();
            int count = 1;
            nodeQueue.Enqueue(root);
            int place = -1;
            HashSet<TreeNode> visited = new HashSet<TreeNode>();
            while (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    TreeNode cur_node = nodeQueue.Dequeue();
                    if (cur_node.left != null)
                    {
                        nodeQueue.Enqueue(cur_node.left);
                        upNodeList.Add(cur_node);
                        visited.Add(cur_node.left);
                    }
                    if (cur_node.right != null)
                    {
                        if (visited.Contains(cur_node.right))
                        {
                            TreeNode upNode = upNodeList[place];
                            if (upNode.left == cur_node)
                            {
                                upNode.left = null;
                            }
                            else
                            {
                                upNode.right = null;
                            }
                            return root;
                        }
                        nodeQueue.Enqueue(cur_node.right);
                        visited.Add(cur_node.right);
                        upNodeList.Add(cur_node);
                    }
                    place++;
                }
                count = nodeQueue.Count;
            }
            return root;
        }
    }
}
