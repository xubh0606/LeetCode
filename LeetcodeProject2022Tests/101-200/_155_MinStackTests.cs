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
    public class _155_MinStackTests
    {
        [TestMethod()]
        public void _155_MinStackTest()
        {

            _155_MinStack minStack = new _155_MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin(); //--> 返回 - 3.
          minStack.Pop();
            minStack.Top(); //--> 返回 0.
       minStack.GetMin();    // 返回 - 2.
        }
    }
}