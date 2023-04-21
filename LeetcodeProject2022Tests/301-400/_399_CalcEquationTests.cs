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
    public class _399_CalcEquationTests
    {
        [TestMethod()]
        public void CalcEquationTest()
        {
            IList<IList<string>> equations = ChangeStringToList.GetIListIListForString("[[a,b],[b,c]]");
            double[] values = new double[] { 2.0, 3.0 };
            IList<IList<string>> queries = ChangeStringToList.GetIListIListForString("[[a,c],[b,a],[a,e],[a,a],[x,x]]");
            _399_CalcEquation solution = new _399_CalcEquation();
            double[] target = new double[] { 6.0, 0.5, -1.0, 1.0, -1.0 };
            double[] res = solution.CalcEquation(equations, values, queries);
            Assert.AreEqual(res.Length, target.Length);
        }
    }
}