using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _117_Connect2Tests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            //root = [1,2,3,4,5,null,7]
            Node root = new Node(1);
            Node child1 = new Node(2);
            Node child2 = new Node(3);
            Node child3 = new Node(4);
            Node child4 = new Node(5);
            Node child6 = new Node(7);
            root.left = child1;
            root.right = child2;
            child1.left = child3;
            child1.right = child4;
            child2.right = child6;
            _117_Connect2 solution = new _117_Connect2();
            solution.Connect(root);
            Assert.AreEqual(null, root.next);
            Assert.AreEqual(null, child2.next);
            Assert.AreEqual(null, child6.next);
        }
    }
}