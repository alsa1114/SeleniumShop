using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumShopTest.StartDriver;

namespace SeleniumShopTest.PageObjects.Pages
{
    public  class TShirtPage: Initialize
    {
        /// <summary>
        /// T-Shirt page locators
        /// </summary>
        private IWebElement TShirtLnk => driver.FindElement(By.XPath("//a[@title = 'T-shirts']"));
        private IWebElement TShirtArg => driver.FindElement(By.CssSelector("span.cat-name"));

        /// <summary>
        /// Checking T-Shirt page
        /// </summary>
        public void CheckTShirtLink()
        {
            TShirtLnk.Click();
            Assert.That(TShirtArg.Displayed, Is.True);
        }
    }
}


