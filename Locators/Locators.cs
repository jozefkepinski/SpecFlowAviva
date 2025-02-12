using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAviva.Locators
{
    public class Locators
    {
        public By accept_all_coockies_button = By.XPath("//button[@id='onetrust-accept-btn-handler']");
    }
}
