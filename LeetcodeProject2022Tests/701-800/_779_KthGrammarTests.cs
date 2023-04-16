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
    public class _779_KthGrammarTests
    {
        [TestMethod()]
        public void KthGrammarTest()
        {
            int n = 2, k = 2;
            _779_KthGrammar solution = new _779_KthGrammar();
            Assert.AreEqual(1, solution.KthGrammar(n, k));
        }

    }
}