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

        public IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[3]/center/input[1]"));

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
