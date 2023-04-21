using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _929_NumUniqueEmailsTests
    {
        [TestMethod()]
        public void NumUniqueEmailsTest()
        {
            string[] emails = new string[]{"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"};
            _929_NumUniqueEmails solution = new _929_NumUniqueEmails();
            Assert.AreEqual(2, solution.NumUniqueEmails(emails));
        }
    }
}