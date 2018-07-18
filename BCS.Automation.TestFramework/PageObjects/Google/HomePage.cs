using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS.Automation.TestFramework.PageObjects.Google
{
    public class HomePage
    {
        [FindsBy(How = How.Id, Using = "hplogo")]
        public IWebElement GoogleLogo { get; set; }

        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement SearchBox { get; set; }
        
        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement SearchButton { get; set; }
        
        public HomePage()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Browser.WebDriver, TimeSpan.FromSeconds(30)));
        }
        
        public void FillUpSearchBox(string text)
        {
            Command.SendKeys(SearchBox, text);
        }

        public void ClearSearchBox()
        {
            Command.Clear(SearchBox);
        }

        public void ClickGoogleLogo()
        {
            Command.Click(GoogleLogo);
        }

        public void ClickGoogleSearch()
        {
            Command.Click(SearchButton);
        }

        public void PressEnterOnSearchBox()
        {
            Command.SendKeys(SearchBox, Keys.Enter);
        }
    }
}
