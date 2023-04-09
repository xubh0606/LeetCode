using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _559_MaxDepthTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            Node root = new Node(1);
            root.children = new List<Node>();
            root.children.Add(new Node(2));
            root.children.Add(new Node(3));
            Node root2 = new Node(4);
            root2.children = new List<Node>();
            root2.children.Add(new Node(5));
            root2.children.Add(new Node(6));
            root.children.Add(root2);
            _559_MaxDepth solution = new _559_MaxDepth();
            Assert.AreEqual(3, solution.MaxDepth(root));
        }
    }
}