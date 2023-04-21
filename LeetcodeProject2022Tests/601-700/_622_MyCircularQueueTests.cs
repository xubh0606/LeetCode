using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _622_MyCircularQueueTests
    {
        [TestMethod()]
        public void _622_MyCircularQueueTest()
        {
            _622_MyCircularQueue circularQueue = new _622_MyCircularQueue(3); // 设置长度为 3
            circularQueue.EnQueue(1);  // 返回 true
            circularQueue.EnQueue(2);  // 返回 true
            circularQueue.EnQueue(3);  // 返回 true
            circularQueue.EnQueue(4);  // 返回 false，队列已满
            circularQueue.Rear();  // 返回 3
            circularQueue.IsFull();  // 返回 true
            circularQueue.DeQueue();  // 返回 true
            circularQueue.EnQueue(4);  // 返回 true
            circularQueue.Rear();  // 返回 4
        }
    }
}