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
    public class OFF57_FindContinuousSequenceTests
    {
        [TestMethod()]
        public void FindContinuousSequenceTest()
        {
            int target = 9;
            OFF57_FindContinuousSequence solution = new OFF57_FindContinuousSequence();
            Assert.AreEqual(2, solution.FindContinuousSequence(target).Length);
        }
    }
}