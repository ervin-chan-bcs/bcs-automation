using BCS.Automation.TestFramework;
using BCS.Automation.TestFramework.PageObjects.Google;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BCS.Automation.Tests.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps : BaseSteps
    {
        HomePage homePage = null;
        SearchPage searchPage = null;

        [BeforeScenario("googlesearch")]
        public void Initialize()
        {
            this.BaseInitialize();
            Browser.Initialize();
            homePage = new HomePage();
            searchPage = new SearchPage();
        }

        [AfterScenario("googlesearch")]
        public void Close()
        {
            Browser.Quit();
        }

        [Given(@"I go to (.*)")]
        public void GivenIGoToWww_Google_Com(string url)
        {
            Browser.GoToURL(url);
        }
        
        [When(@"the site has loaded")]
        public void WhenTheSiteHasLoaded()
        {
            
        }
        
        [Then(@"I should see the search page")]
        public void ThenIShouldSeeTheSearchPage()
        {
           
        }

        [Then(@"I should type (.*) in the searchbox")]
        public void ThenIShouldTypeHelloInTheSearchbox(string text)
        {
            homePage.FillUpSearchBox(text);
        }

        [Then(@"I clear the searchbox")]
        public void ThenIClearTheSearchbox()
        {
            homePage.ClearSearchBox();
        }

        [Then(@"I click the Google icon")]
        public void ThenIClickTheGoogleIcon()
        {
            homePage.ClickGoogleLogo();
        }

        [Then(@"I press enter")]
        public void ThenIPressEnter()
        {
            homePage.PressEnterOnSearchBox();
        }

        [Then(@"I click the search button")]
        public void ThenIClickTheSearchButton()
        {
            homePage.ClickGoogleSearch();
        }

        [Then(@"I check if the Google logo is in the search page")]
        public void ThenICheckIfTheGoogleLogoIsInTheSearchPage()
        {
            Assert.IsTrue(searchPage.IsAt(), "Search page did not show Google Logo");
        }

        [Then(@"I take a screenshot of the page")]
        public void ThenITakeAScreenshotOfThePage()
        {
            Logger.TakeScreenshot(Context.TestDeploymentDirectory, "testscreenshot");
            Logger.TakeScreenshot(this.ScreenshotFileName);
        }

    }
}
