using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CompanyPortal.Models;
namespace CompanyPortalTest
{
    [TestClass]
    public class UserRolesTests
    {
        [TestMethod]
        public void UserRole_UserIsSuperAdmin_ReturnsTrue()
        {
            Assert.AreEqual(RoleName.CanManageLink, "CanManageLink");
        }

        [TestMethod]
        public void UserRole_UserIsSuperAdmin_ReturnsFalse()
        {
            Assert.AreNotEqual(RoleName.CanManageLink, "CanManHJHJHHJageLink");
        }

        [TestMethod]
        public void UserRole_UserIsGlobalAdmin_ReturnsTrue()
        {
            Assert.AreEqual(RoleName.CanViewGlobalLink, "CanViewGlobalLink");
        }

        [TestMethod]
        public void UserRole_UserIsGlobalAdmin_ReturnsFalse()
        {
            Assert.AreNotEqual(RoleName.CanViewGlobalLink, "CanManHJHJHHJageLink");
        }


        [TestMethod]
        public void UserRole_UserIsEngineeringAdmin_ReturnsTrue()
        {
            Assert.AreEqual(RoleName.CanViewGlobalEngLink, "CanViewGlobalEngLink");
        }

        [TestMethod]
        public void UserRole_UserIsEngineeringAdmin_ReturnsFalse()
        {
            Assert.AreNotEqual(RoleName.CanViewGlobalEngLink, "CanManHJHJHHJageLink");
        }

        [TestMethod]
        public void UserRole_UserIsFinanceAdmin_ReturnsTrue()
        {
            Assert.AreEqual(RoleName.CanViewGlobalFinanceLink, "CanViewGlobalFinanceLink");
        }

        [TestMethod]
        public void UserRole_UserIsFinanceAdmin_ReturnsFalse()
        {
            Assert.AreNotEqual(RoleName.CanViewGlobalFinanceLink, "CanManHJHJHHJageLink");
        }

        [TestMethod]
        public void UserRole_UserIsHRAdmin_ReturnsTrue()
        {
            Assert.AreEqual(RoleName.CanViewGlobalHRLink, "CanViewGlobalHRLink");
        }

        [TestMethod]
        public void UserRole_UserIsHRAdmin_ReturnsFalse()
        {
            Assert.AreNotEqual(RoleName.CanViewGlobalHRLink, "CanManHJHJHHJageLink");
        }

        [TestMethod]
        public void UserRole_UserIsSalesAdmin_ReturnsTrue()
        {
            Assert.AreEqual(RoleName.CanViewGlobalSalesLink, "CanViewGlobalSalesLink");
        }

        [TestMethod]
        public void UserRole_UserIsSalesAdmin_ReturnsFalse()
        {
            Assert.AreNotEqual(RoleName.CanViewGlobalSalesLink, "CanManHJHJHHJageLink");
        }


    }
}
