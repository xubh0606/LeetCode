using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _431_EncodeTests
    {
        [TestMethod()]
        public void EncodeTest()
        {
            Node root = new Node(1);
            root.children = new List<Node>();
            root.children.Add(new Node(2));
            root.children.Add(new Node(3));
            root.children.Add(new Node(4));
            Node root2 = new Node(5);
            root2.children = new List<Node>();
            root2.children.Add(new Node(6));
            root2.children.Add(new Node(7));
            _431_Encode solution = new _431_Encode();
            TreeNode treeNodeRoot = solution.Encode(root);
            Node backNode = solution.Decode(treeNodeRoot);
            Assert.AreEqual(1, backNode.val);
        }
    }
}