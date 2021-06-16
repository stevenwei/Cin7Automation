using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Cin7Automation.Pages
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;

        }

        private IWebElement LoginPageButtonElement => _webDriver.FindElement(By.ClassName("cta-tertiary"));
        private IWebElement PricingPageElement => _webDriver.FindElement(By.Id("nav-link directory-link"));

        public void ClickLoginPageButton()
        {
            LoginPageButtonElement.Click();
        }

        public void ClickPricingPageButton()
        {
            PricingPageElement.Click();
        }

    }
}
