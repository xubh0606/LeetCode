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
    public class _638_ShoppingOffersTests
    {
        [TestMethod()]
        public void ShoppingOffersTest()
        {
            IList<int> price = ChangeStringToList.GetIListForInt("[2, 5]");
            IList< int > needs = ChangeStringToList.GetIListForInt("[3, 2]");
            IList<IList<int>> special = ChangeStringToList.GetIListIListForInt("[[3, 0, 5],[1, 2, 10]]");
            _638_ShoppingOffers solution = new _638_ShoppingOffers();
            Assert.AreEqual(14, solution.ShoppingOffers(price, special, needs));
        }
    }
}