using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _338_CountBitsTests
    {
        [TestMethod()]
        public void CountBitsTest()
        {
            int[] target = new int[] { 0, 1, 1 };
            _338_CountBits solution = new _338_CountBits();
            int[] res = solution.CountBits(2);
            Assert.AreEqual(target.Length, res.Length);
            for(int i = 0; i < target.Length; i++)
            {
                Assert.AreEqual(target[i], res[i]);
            }
        }
    }
}