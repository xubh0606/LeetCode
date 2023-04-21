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
    public class _458_PoorPigsTests
    {
        [TestMethod()]
        public void PoorPigsTest()
        {
            int buckets = 1000, minutesToDie = 15, minutesToTest = 60;
            _458_PoorPigs solution = new _458_PoorPigs();
            Assert.AreEqual(5, solution.PoorPigs(buckets, minutesToDie, minutesToTest));
        }
    }
}