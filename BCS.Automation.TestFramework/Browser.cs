using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS.Automation.TestFramework
{
    public static class Browser
    {
        public static IWebDriver WebDriver { get; private set; } = null;

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-popup-blocking");
            WebDriver = new ChromeDriver(options);
            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
        }

        public static void Quit()
        {
            WebDriver.Quit();
        }

        public static void Close()
        {
            WebDriver.Close();
        }

        public static void GoToURL(string url)
        {
            WebDriver.Url = url;
        }

        public static bool ElementExist(By locator)
        {
            try
            {
                WebDriver.FindElement(locator);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement FindElement(By locator)
        {
            return WebDriver.FindElement(locator);
        }

        public static IWebElement WaitForElement(By locator, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, timeout);
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(locator));
            return element;
        }

        public static IWebElement WaitForElementVisible(By locator, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, timeout);
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return element;
        }
        
    }
}
