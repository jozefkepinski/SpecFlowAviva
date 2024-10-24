using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;


namespace SpecFlowAviva.StepDefinitions
{
    [Binding]
    public class DataTableDataDrivenTestingStepDefinitions
    {
        private IWebDriver _driver;
        public DataTableDataDrivenTestingStepDefinitions(IWebDriver driver) 
        { 
            _driver = driver;
        }

        [Then(@"the title should be")]
        public void ThenTheTitleShouldBe(Table table)
        {
            var expectedTitle = table.CreateSet<Titles>();
            foreach (var title in expectedTitle)
            {
            var actualTitle = _driver.Title;
            Assert.AreEqual(title.Title, actualTitle);
            }
        }
        public record Titles
        {
            public string Title { get; set; }
        }
    }
}
