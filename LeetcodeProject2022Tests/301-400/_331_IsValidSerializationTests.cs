using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _331_IsValidSerializationTests
    {
        [TestMethod()]
        public void IsValidSerializationTest()
        {
            string preorder = "9,3,4,#,#,1,#,#,2,#,6,#,#";
            _331_IsValidSerialization solution = new _331_IsValidSerialization();
            Assert.IsTrue(solution.IsValidSerialization(preorder));
        }
    }
}