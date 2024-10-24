using OpenQA.Selenium;
using SpecFlowAviva.Pages;


namespace SpecFlowAviva.StepDefinitions
{
    [Binding]
    public sealed class PageObjectsModelStepDefinition
    {
        private IWebDriver _driver;
        MainPage _mainPage;
        public PageObjectsModelStepDefinition(IWebDriver driver) 
        {
            _driver = driver;
        }

        [When(@"Accept all cookies")]
        public void WhenAcceptAllCookies()
        {
            _driver.Url = "https://www.aviva.com/";
            _driver.Navigate();
            _mainPage = new MainPage(_driver);
            _mainPage.AcceptCookies();
        }
    }
}
