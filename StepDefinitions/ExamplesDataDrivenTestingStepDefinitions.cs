using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowAviva.StepDefinitions
{
    [Binding]
    public class ExamplesDataDrivenTestingStepDefinitions
    {
        private IWebDriver _driver;
        public ExamplesDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
        }
        [Then(@"the title should be (.*)")]
        public void ThenTheTitleShouldBe(string expectedTitle)
        {
            //Second possibility is to use Table instead Examples
            //var expectedTitle = table.CreateSet<Titles>();
            //foreach (var title in expectedTitle)
            //{
            //    Console.WriteLine($"Titles are: {title.Title}");
            var actualTitle = _driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            //}

        }
    }
        
}
