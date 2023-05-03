using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.deserialize(codec.serialize(root));
    public class _428_serialize
    {// Encodes a tree to a single string.
        public string Serialize(Node root)
        {
            if (root == null)
            {
                return "";
            }
            if (root.children == null)
            {
                return root.val.ToString();
            }
            string res = root.val.ToString();
            res += '[';
            IList<Node> c = root.children;
            for (int i = 0; i < c.Count; i++)
            {
                res += Serialize(c[i]) + ' ';
            }
            return res + ']';
        }

        // Decodes your encoded data to tree.
        public Node Deserialize(string data)
        {
            if (data == "")
            {
                return null;
            }
            return ReSz(data, 0, data.Length - 1);
        }

        Node ReSz(string data, int left, int right)
        {
            string cut = "";
            while (left <= right)
            {
                cut += data[left];
                left++;
                if (left < right && data[left] == '[')
                {
                    break;
                }
            }
            int value = int.Parse(cut);
            if (left > right)
            {
                return new Node(value, new List<Node>());
            }
            Node root = new Node(value, RZ(data, left + 1, right - 2));
            return root;
        }

        IList<Node> RZ(string data, int left, int right)
        {
            IList<Node> c = new List<Node>();
            int end = left + 1;
            while (end <= right + 1)
            {
                while (data[end] != '[' && data[end] != ' ' && end <= right)
                {
                    end++;
                }
                if (data[end] == '[')
                {
                    int count = 1;
                    while (count > 0)
                    {
                        end++;
                        if (data[end] == '[')
                        {
                            count++;
                        }
                        if (data[end] == ']')
                        {
                            count--;
                        }
                    }
                    end++;
                }
                c.Add(ReSz(data, left, end - 1));
                left = end + 1;
                end = left + 1;
            }
            return c;
        }
    }
}
