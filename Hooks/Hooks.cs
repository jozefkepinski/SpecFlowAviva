using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowAviva.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("@TestAvivaWebPage")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("This is BeforeScenario before selected scenario by Tag.");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            _container.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}