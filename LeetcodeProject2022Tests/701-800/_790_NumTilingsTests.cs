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
    public class _790_NumTilingsTests
    {
        [TestMethod()]
        public void NumTilingsTest()
        {
            _790_NumTilings solution = new _790_NumTilings();
            Assert.AreEqual(5, solution.NumTilings(3));
        }
    }
}