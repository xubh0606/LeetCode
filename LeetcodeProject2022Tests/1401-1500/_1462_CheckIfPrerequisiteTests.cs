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
    public class _1462_CheckIfPrerequisiteTests
    {
        [TestMethod()]
        public void CheckIfPrerequisiteTest()
        {
            int numCourses = 2;
            int[][] prerequisites = ChangeStringToList.GetArrOfArrForInt("[[1, 0]]");
            int[][] queries = ChangeStringToList.GetArrOfArrForInt("[[0, 1],[1,0]]");
            _1462_CheckIfPrerequisite solution = new _1462_CheckIfPrerequisite();
            Assert.IsTrue(solution.CheckIfPrerequisite(numCourses, prerequisites, queries)[1]);
            Assert.IsFalse(solution.CheckIfPrerequisite(numCourses, prerequisites, queries)[0]);
        }
    }
}