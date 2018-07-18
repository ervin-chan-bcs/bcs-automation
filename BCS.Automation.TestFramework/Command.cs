using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS.Automation.TestFramework
{
    public static class Command
    {
        public static void SendKeys(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void Click(IWebElement element)
        {
            element.Click();
        }

        public static void Clear(IWebElement element)
        {
            element.Clear();
        }

        public static string Text(IWebElement element)
        {
            return element.Text;
        }
    }
}
