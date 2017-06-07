using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DinerMax3000UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var resultMenus =DinerMax3000.BusinessLayer.Menu.GetAllMenus();
            Assert.IsTrue(resultMenus.Count > 0);
        }
    }
}
