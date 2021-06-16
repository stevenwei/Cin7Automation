using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Cin7Automation.Pages;

namespace Cin7Automation.Steps
{
    [Binding]
    class LoginSteps
    {

        IWebDriver currentDriver = null;

        LoginPage page = new LoginPage();


        [When(@"I enter my (.*) and (.*)")]
        public void WhenIEnterMyAbcAnd(string username, string password)
        {
            page.EnterLoginDetails(username, password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            page.ClickLogin();
        }

    }
}
