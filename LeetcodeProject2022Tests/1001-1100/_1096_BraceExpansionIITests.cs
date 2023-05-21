using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1001_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100.Tests
{
    [TestClass()]
    public class _1096_BraceExpansionIITests
    {
        [TestMethod()]
        public void BraceExpansionIITest()
        {
            string ex = "{{a,z},a{b,c},{ab,z}}";
            _1096_BraceExpansionII solution = new _1096_BraceExpansionII();
            Assert.AreEqual(4, solution.BraceExpansionII(ex).Count);
        }
    }
}