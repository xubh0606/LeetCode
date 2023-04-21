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
    public class _690_GetImportanceTests
    {
        [TestMethod()]
        public void GetImportanceTest()
        {
            //输入：[[1, 5, [2, 3]], [2, 3, []], [3, 3, []]], 1
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            employees.Add(new Employee());
            employees.Add(new Employee());
            employees[0].id = 1;
            employees[1].id = 2;
            employees[2].id = 3;
            employees[0].importance = 5;
            employees[1].importance = 3;
            employees[2].importance = 3;
            employees[0].subordinates.Add(1);
            employees[0].subordinates.Add(2);
            _690_GetImportance solution = new _690_GetImportance();
            Assert.AreEqual(11, solution.GetImportance(employees, 1));
            //输出：11
        }
    }
}