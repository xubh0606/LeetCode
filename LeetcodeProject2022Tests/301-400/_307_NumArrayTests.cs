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
    public class _307_NumArrayTests
    {
        [TestMethod()]
        public void _307_NumArrayTest()
        {

            _307_NumArray numArray = new _307_NumArray(new int[] { 7, 2, 7,2,0 });
            numArray.Update(6, 6);
            numArray.Update(0, 2);
            numArray.Update(0, 9);
        }
    }
}