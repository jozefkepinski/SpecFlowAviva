using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace SpecFlowAviva.StepDefinitions
{
    [Binding]
    public sealed class AvivaMainPageCheckStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private IWebDriver _driver;
        [Given(@"Open web browser")]
        public void GivenOpenWebBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [When(@"Navigated to the Aviva home")]
        public void WhenNavigatedToTheAvivaHome()
        {
            _driver.Url = "https://www.aviva.com/";
            _driver.Navigate();
            var accept_all_coockies_button = _driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']"));
            accept_all_coockies_button.Click();
        }

        [Then(@"The title should be ""([^""]*)""")]
        public void ThenTheTitleShouldBe(string expectedTitle)
        {
            var actualTitle = _driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            _driver.Quit();
        }

    }
}
