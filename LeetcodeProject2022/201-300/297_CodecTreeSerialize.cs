using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public  class _297_CodecTreeSerialize
    {
        //分割字符为‘|’ 第一个数字为总长度，也就是分为两个输出数组
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                return "";
            }
            //用 | 代表分割，用#代表空位。严格地进行一一对应式层序遍历
            string str = root.val.ToString();
            Queue<TreeNode> levelNodeSet = new Queue<TreeNode>();
            levelNodeSet.Enqueue(root);
            while (levelNodeSet.Count > 0)
            {
                int c = levelNodeSet.Count;
                for (int i = 0; i < c; i++)
                {
                    TreeNode cur = levelNodeSet.Dequeue();
                    if (cur.left != null)
                    {
                        levelNodeSet.Enqueue(cur.left);
                        str += '|' + cur.left.val.ToString();
                    }
                    else
                    {
                        str += "|#";
                    }
                    if (cur.right != null)
                    {
                        levelNodeSet.Enqueue(cur.right);
                        str += '|' + cur.right.val.ToString();
                    }
                    else
                    {
                        str += "|#";
                    }
                }
            }
            return str + '|';
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            //正常逻辑下需要先确认是否可以反序列化
            //CheakData();
            if (data.Length == 0)
            {
                return null;
            }
            int val = 0;
            int index = 0;
            if (data[index] == '-')
            {
                index++;
                while (data[index] != '|')
                {
                    val = val * 10 + data[index] - '0';
                    index++;
                }
                val = -val;
            }
            else
            {
                while (data[index] != '|')
                {
                    val = val * 10 + data[index] - '0';
                    index++;
                }
            }
            Queue<TreeNode> levelNodeSet = new Queue<TreeNode>();
            TreeNode root = new TreeNode(val);
            levelNodeSet.Enqueue(root);
            while (levelNodeSet.Count > 0)
            {
                int c = levelNodeSet.Count;
                for (int i = 0; i < c; i++)
                {
                    TreeNode cur = levelNodeSet.Dequeue();
                    index++;
                    if (data[index] != '#')
                    {
                        val = 0;
                        if (data[index] == '-')
                        {
                            index++;
                            while (data[index] != '|')
                            {
                                val = val * 10 + data[index] - '0';
                                index++;
                            }
                            val = -val;
                        }
                        else
                        {
                            while (data[index] != '|')
                            {
                                val = val * 10 + data[index] - '0';
                                index++;
                            }
                        }
                        cur.left = new TreeNode(val);
                        levelNodeSet.Enqueue(cur.left);
                    }
                    else
                    {
                        index++;
                    }
                    index++;
                    if (data[index] != '#')
                    {
                        val = 0;
                        if (data[index] == '-')
                        {
                            index++;
                            while (data[index] != '|')
                            {
                                val = val * 10 + data[index] - '0';
                                index++;
                            }
                            val = -val;
                        }
                        else
                        {
                            while (data[index] != '|')
                            {
                                val = val * 10 + data[index] - '0';
                                index++;
                            }
                        }
                        cur.right = new TreeNode(val);
                        levelNodeSet.Enqueue(cur.right);
                    }
                    else
                    {
                        index++;
                    }
                }
            }
            return root;
        }
    }
}
