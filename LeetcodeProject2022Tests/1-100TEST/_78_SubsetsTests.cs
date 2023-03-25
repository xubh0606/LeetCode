using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022Tests._1_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022Tests._1_200
{
    [TestClass()]
    public class _78_SubsetsTests
    {
        [TestMethod()]
        public void SubsetsTest()
        {
            int[] nums = new int[] { 1, 2, 3 };
            ChangeStringToList change = new ChangeStringToList();
            _78_Subsets solution = new _78_Subsets();
            Assert.AreEqual(8, solution.Subsets(nums).Count);
        }
    }
}