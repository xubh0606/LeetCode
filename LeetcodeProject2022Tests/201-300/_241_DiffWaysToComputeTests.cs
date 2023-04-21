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
    public class _241_DiffWaysToComputeTests
    {
        [TestMethod()]
        public void DiffWaysToComputeTest()
        {
            string expression = "2-1-1";
            _241_DiffWaysToCompute solution = new _241_DiffWaysToCompute();
            Assert.AreEqual(2, solution.DiffWaysToCompute(expression)[0]);
            Assert.AreEqual(0, solution.DiffWaysToCompute(expression)[1]);
        }
    }
}