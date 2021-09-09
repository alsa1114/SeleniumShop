using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumShopTest.StartDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumShopTest.PageObjects.Pages
{
    class T_ShirtPage: Initialize
    {
        private IWebElement TShirtLnk => driver.FindElement(By.XPath("//a[@title = 'T-shirts']"));
        private IWebElement TShirtArg => driver.FindElement(By.CssSelector("span.cat-name"));


        public void CheckTShirtLink()
        {
            TShirtLnk.Click();
            Assert.That(TShirtArg.Displayed, Is.True);
        }

    }
}


