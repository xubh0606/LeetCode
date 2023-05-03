using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1491_AverageTests
    {
        [TestMethod()]
        public void AverageTest()
        {
            int[] salary = new int[] { 4000, 3000, 1000, 2000 };
            _1491_Average solution = new _1491_Average();
            Assert.AreEqual(2500.000, solution.Average(salary));
        }
    }
}