using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConstructionEquipmentsSol;
using Accounts;

namespace ConstructoShopUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CalculateHeavyRentalPrice()
        {
            var r = new Home();
            double price =r.Fn_CalculateHeavyPrice(5);
            Assert.AreEqual(400, price);
        }
        [TestMethod]
        public void CalculateRegularRentalPrice()
        {
            var r = new Home();
            double price = r.Fn_CalculateRegularPrice(5);
            Assert.AreEqual(340, price);
        }
        [TestMethod]
        public void CalculateSpecializedRentalPrice()
        {
            var r = new Home();
            double price = r.Fn_CalculateSpecializedPrice(5);
            Assert.AreEqual(260, price);
        }
        [TestMethod]
        public void CalculateAddedPoints()
        {
            var r = new Home();
            double points = r.fn_CalculatePoints(0,0,2,2,2);
            Assert.AreEqual(3, points);
        }
        [TestMethod]
        public void LoginTest()
        {
            var r = new Account();
            bool flag = r.Fn_ValidateUser("admin","Pass");
            Assert.AreEqual(false, flag);
        }
    }
}
