using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAviva.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;
        public MainPage(IWebDriver driver) 
        {
            _driver = driver;
        }

        By accept_all_coockies_button = By.XPath("//button[@id='onetrust-accept-btn-handler']");

        public MainPage AcceptCookies()
        {
            _driver.FindElement(accept_all_coockies_button).Click();
            return new MainPage(_driver);
        }
}
}
