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
    public class _484_FindPermutationTests
    {
        [TestMethod()]
        public void FindPermutationTest()
        {
            string s = "DI";
            _484_FindPermutation solution = new _484_FindPermutation();
            //输出： [2,1,3]
            Assert.AreEqual(3, solution.FindPermutation(s));
        }
    }
}