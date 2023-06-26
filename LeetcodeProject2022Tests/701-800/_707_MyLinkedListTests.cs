using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _707_MyLinkedListTests
    {
        [TestMethod()]
        public void _707_MyLinkedListTest()
        {
            _707_MyLinkedList myLinkedList = new _707_MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // 链表变为 1->2->3
            myLinkedList.Get(1);              // 返回 2
            myLinkedList.DeleteAtIndex(1);    // 现在，链表变为 1->3
            myLinkedList.Get(1);              // 返回 3
        }
    }
}