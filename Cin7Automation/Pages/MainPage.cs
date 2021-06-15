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
        private const string Cin7Url = "https://www.cin7.com/";
        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;

        }

        private IWebElement LoginPageButtonElement => _webDriver.FindElement(By.Id("first-number"));
        private IWebElement ProductPageElement => _webDriver.FindElement(By.Id("second-number"));
        private IWebElement PricingPageElement => _webDriver.FindElement(By.Id("add-button"));
        private IWebElement ResourcesPageElement => _webDriver.FindElement(By.Id("result"));

        public void ClickLoginPageButton()
        {
            LoginPageButtonElement.Click();
        }


    
    }
}
