using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _431_Encode
    {// Encodes an n-ary tree to a binary tree.
        public TreeNode Encode(Node root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode treeRoot = new TreeNode(root.val);
            if (root.children.Count == 0)
            {
                return treeRoot;
            }
            IList<Node> list = root.children;
            treeRoot.left = Encode(list[0]);
            TreeNode cur = treeRoot.left;
            for (int i = 1; i < list.Count; i++)
            {
                cur.right = Encode(list[i]);
                cur = cur.right;
            }
            return treeRoot;
        }

        // Decodes your binary tree to an n-ary tree.
        public Node Decode(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            IList<Node> list = new List<Node>();
            Node OriginNode = new Node(root.val, list);
            if (root.left == null)
            {
                return OriginNode;
            }
            TreeNode cur = root.left;
            while (cur != null)
            {
                list.Add(Decode(cur));
                cur = cur.right;
            }
            OriginNode.children = list;
            return OriginNode;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(root));
}
