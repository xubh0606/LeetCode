using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _684_FindRedundantConnectionTests
    {
        [TestMethod()]
        public void FindRedundantConnectionTest()
        {
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[1, 2], [1,3], [2,3]]");
            _684_FindRedundantConnection soution = new _684_FindRedundantConnection();
            Assert.AreEqual(2, soution.FindRedundantConnection(edges)[0]);
            Assert.AreEqual(3, soution.FindRedundantConnection(edges)[1]);
        }
    }
}