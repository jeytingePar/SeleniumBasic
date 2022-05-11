using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasic
{
    class GooglePage
    {
        private IWebDriver driver;

        public GooglePage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement SearchBox => driver.FindElement(By.CssSelector("input[title*=\"Search\"]"));

        public IWebElement SearchButton => driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b"));

        private string url = "http://www.google.com";

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IsOnResultsPage()
        {
            return driver.Url.Contains("/search");
        }

        public void SearchFor(string search)
        {
            SearchBox.SendKeys(search);
            SearchBox.SendKeys(Keys.Escape);
            SearchButton.Click();
        }
    }
}
