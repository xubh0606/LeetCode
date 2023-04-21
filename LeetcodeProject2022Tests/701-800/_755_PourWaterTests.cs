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
    public class _755_PourWaterTests
    {
        [TestMethod()]
        public void PourWaterTest()
        {
            int[] heights = new int[] { 2, 1, 1, 2, 1, 2, 2 };
            int V = 4, K = 3;
            _755_PourWater solution = new _755_PourWater();
            int[] res = solution.PourWater(heights, V, K);
            int[] target = new int[] { 2, 2, 2, 3, 2, 2, 2 };
            for(int i = 0; i < target.Length; i++)
            {
                Assert.AreEqual(target[i], res[i]);
            }
        }
    }
}