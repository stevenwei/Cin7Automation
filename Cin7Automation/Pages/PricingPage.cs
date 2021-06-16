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
    class PricingPage
    {
        public PricingPage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }

        [FindsBy(How = How.Id, Using = "changeable-price-Ecommerce")]
        public IWebElement smallBusinessPrice;

        [FindsBy(How = How.Id, Using = "changeable-price-Wholesale")]
        public IWebElement businessPrice;

        [FindsBy(How = How.Id, Using = "changeable-price-MultiChannel")]
        public IWebElement advancedPrice;


        public string GetSmallBusinessPrices()
        {
            return smallBusinessPrice.Text.ToString();
        }

        public string GetBusinessPrices()
        {
            return businessPrice.Text.ToString();
        }

        public string GetAdvancedBusinessPrices()
        {
            return advancedPrice.Text.ToString();
        }

    }
}
