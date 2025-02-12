using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowAviva.Locators;

namespace SpecFlowAviva.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;
        //private Locators.Locators _locators;
        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By accept_all_coockies_button = By.XPath("//button[@id='onetrust-accept-btn-handler']");

        public MainPage AcceptCookies()
        {
            //_locators = new Locators.Locators();
            //_driver.FindElement(accept_all_coockies_button).Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //Wait for the element to be visible
            IWebElement element = wait.Until(drv => drv.FindElement(accept_all_coockies_button));
            return new MainPage(_driver);
        }
}
}
