using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class OFF0814_CountEvalTests
    {
        [TestMethod()]
        public void CountEvalTest()
        {
            string s = "1^0|0|1";
            OFF0814_CountEval solution = new OFF0814_CountEval();
            Assert.AreEqual(2, solution.CountEval(s, 0));
        }
    }
}