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
    public class _703_KthLargestTests
    {
        [TestMethod()]
        public void _703_KthLargestTest()
        {
            _703_KthLargest kthLargest = new _703_KthLargest(3, new int[] { 4, 5, 8, 2 });
            Assert.AreEqual(4, kthLargest.Add(3));   // return 4
            Assert.AreEqual(5, kthLargest.Add(5));   // return 5
            Assert.AreEqual(5, kthLargest.Add(10));  // return 5
            Assert.AreEqual(8, kthLargest.Add(9));   // return 8
            Assert.AreEqual(8, kthLargest.Add(4));   // return 8
        }
    }
}