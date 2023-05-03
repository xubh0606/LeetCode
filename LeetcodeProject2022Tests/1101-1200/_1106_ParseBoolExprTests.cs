using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1106_ParseBoolExprTests
    {
        [TestMethod()]
        public void ParseBoolExprTest()
        {
            _1106_ParseBoolExpr solution = new _1106_ParseBoolExpr();
            string exception = "!(&(!(!(!(&(|(f,f,t),&(&(f),&(!(t),&(f),|(f)),&(!(&(f)),&(t),|(f,f,t))),&(t))))),&(&(!(t),!(|(f,f,t)),!(&(f))),!(|(f,f,t)),&(|(f,f,t),&(&(f),&(!(t),&(f),|(f)),&(!(&(f)),&(t),|(f,f,t))),&(t))),!(&(!(&(|(f,f,t),&(&(f),&(!(t),&(f),|(f)),&(!(&(f)),&(t),|(f,f,t))),&(t))),!(!(&(f))),&(!(t),&(f),|(f))))))";
            Assert.AreEqual(true, solution.ParseBoolExpr(exception));
        }

        [TestMethod()]
        public void ParseBoolExprTest2()
        {
            _1106_ParseBoolExpr solution = new _1106_ParseBoolExpr();
            //"!(&(&(!(&(f)),&(t),|(f,f,t)),&(t),&(t,t,f)))"
            string expression = "&(!(&(f)),&(t),|(f,f,t))";
            Assert.AreEqual(true, solution.ParseBoolExpr(expression));
        }
    }
}