using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using System.Configuration;
using Cin7Automation.Pages;

namespace Cin7Automation.Steps
{
    [Binding]
    class MainPageSteps
    {
        IWebDriver currentDriver = null;

        MainPage page = new MainPage();

        [Given(@"I visit Cinseven website")]
        public void GivenIVisitCinsevenWebsite()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            currentDriver = Browser.Current;
        }


        [Given(@"I can see Cinseven main logo")]
        public void GivenICanSeeCinsevenMainLogo()
        {
            if (currentDriver.FindElement(By.ClassName("site-logo")).Displayed == true)
                Console.WriteLine("Logo displayed");
            else
                Console.WriteLine("Logo not displaying");
        }

        [Given(@"I go to login page")]
        public void GivenIGoToLoginPage()
        {
            MainPage.Clickloginbutton();
        }

    }
}
