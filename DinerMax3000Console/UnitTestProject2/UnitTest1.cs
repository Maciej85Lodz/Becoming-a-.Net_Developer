using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DinerMax3000.BusinessLayer;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var resultMenus = Menu.GetAllMenus();
            Assert.IsTrue(resultMenus.Count > 0);

            int countBeforeSave = resultMenus[0].Items.Count;
            resultMenus[0].SaveNewMenuItem("UT_Name", "UT_Description", 10.00);
            resultMenus = Menu.GetAllMenus();
            int countAfterSave = resultMenus[0].Items.Count;

            Assert.IsTrue(countBeforeSave < countAfterSave);
        }
    }
}
