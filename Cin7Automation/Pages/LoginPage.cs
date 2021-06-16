using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cin7Automation.Pages
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }

        [FindsBy(How = How.Id, Using = "EmailOrUsername")]
        public IWebElement txtUserName;

        [FindsBy(How = How.Id, Using = "passwordInput")]
        public IWebElement txtPassword;

        [FindsBy(How = How.ClassName, Using = "btn btn-default btn-red")]
        public IWebElement loginButton;


        public void EnterLoginDetails(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            loginButton.Click();
        }


    }
}
