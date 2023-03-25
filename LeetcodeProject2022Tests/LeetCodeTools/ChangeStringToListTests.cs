using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022.LeetCodeTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022.LeetCodeTools.Tests
{
    [TestClass()]
    public class ChangeStringToListTests
    {
        [TestMethod()]
        public void GetIListIListForIntTest()
        {
            string s = "[[1,3,1],[1,5,1],[4,2,1]]";
            ChangeStringToList solution = new ChangeStringToList();
            Assert.AreEqual(3, solution.GetIListIListForInt(s).Count);
        }
    }
}