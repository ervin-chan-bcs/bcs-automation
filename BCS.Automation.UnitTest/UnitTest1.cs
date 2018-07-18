using System;
using BCS.Automation.TestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCS.Automation.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Browser.Initialize();
            Browser.GoToURL("http://www.google.com");
            Browser.Quit();
        }
    }
}
