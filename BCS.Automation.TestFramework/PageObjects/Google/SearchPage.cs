using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS.Automation.TestFramework.PageObjects.Google
{
    public class SearchPage
    {
        public bool IsAt()
        {
            try
            {
                Browser.WaitForElement(By.Id("dimg_7"), TimeSpan.FromSeconds(60));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
