using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _117_Connect2
    {
        //填充任意二叉树（与完美二叉树区别）的右侧指针，如果为当前层最后一个则为null
        public Node Connect(Node root)
        {
            if (root == null || (root.left == null && root.right == null))
            {
                return root;
            }
            Node up_Head = root;
            while (up_Head != null)
            {
                Node up_Node = up_Head;
                Node cur_Head = new Node(int.MaxValue);
                bool startIsLeft = false;
                while (up_Node != null)
                {
                    if (up_Node.left != null)
                    {
                        cur_Head = up_Node.left;
                        startIsLeft = true;
                        break;
                    }
                    if (up_Node.right != null)
                    {
                        cur_Head = up_Node.right;
                        break;
                    }
                    up_Node = up_Node.next;
                }
                if (cur_Head.val == int.MaxValue)
                {
                    break;
                }
                Node cur_Node = cur_Head;
                if (startIsLeft)
                {
                    if (up_Node.right != null)
                    {
                        cur_Node.next = up_Node.right;
                        cur_Node = cur_Node.next;
                    }
                    startIsLeft = false;
                }
                up_Node = up_Node.next;
                while (up_Node != null)
                {
                    if (up_Node.left != null)
                    {
                        cur_Node.next = up_Node.left;
                        cur_Node = cur_Node.next;
                    }
                    if (up_Node.right != null)
                    {
                        cur_Node.next = up_Node.right;
                        cur_Node = cur_Node.next;
                    }
                    up_Node = up_Node.next;
                }
                up_Head = cur_Head;
            }
            return root;
        }
    }
}
