using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _46_PermuteTests
    {
        [TestMethod()]
        public void PermuteTest()
        {
            //测试时关注总数目即可。
            int[] nums = new int[] { 1, 2, 3 };
            _46_Permute solution = new _46_Permute();
            Assert.AreEqual(6, solution.Permute(nums).Count);
        }
    }
}