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
    public class _281_ZigzagIteratorTests
    {
        [TestMethod()]
        public void _281_ZigzagIteratorTest()
        {
            int[] v1 = new int[] { 1, 2 }, v2 = new int[] { 3, 4, 5, 6 };
            _281_ZigzagIterator zig = new _281_ZigzagIterator(v1, v2);
            IList<int> list = new List<int>();
            while (zig.HasNext())
            {
                list.Add(zig.Next());
            }
            Assert.AreEqual(6, list.Count);
        }
    }
}