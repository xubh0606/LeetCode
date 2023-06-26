using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _232_MyQueueTests
    {
        [TestMethod()]
        public void _232_MyQueueTest()
        {
            _232_MyQueue myQueue = new _232_MyQueue();
            myQueue.Push(1); // queue is: [1]
            myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
            myQueue.Peek(); // return 1
            myQueue.Pop(); // return 1, queue is [2]
            myQueue.Empty(); // return false
        }
    }
}