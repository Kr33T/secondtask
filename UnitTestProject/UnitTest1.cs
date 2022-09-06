using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using МЭ_вар2;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetPercentMoney()
        {
            var cont = new User_contribution(750000);

            double result = cont.Get_persentMoney();
            double expected = 99750;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTax()
        {
            var cont = new User_contribution(750000);
            int result = cont.tax;
            int expected = 30;

            Assert.AreEqual(expected, result);
        }
    }
}
