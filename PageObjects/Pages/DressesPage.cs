using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumShopTest.StartDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumShopTest.PageObjects.Pages
{
   public  class DressesPage: Initialize
    {
        /// <summary>
        ///Dresses page locators
        /// </summary>
        private IWebElement DressesLnk => driver.FindElement(By.ClassName("sf-with-ul"));
        private IWebElement DressesArg => driver.FindElement(By.CssSelector("span.cat-name"));

        /// <summary>
        /// Checking dresses page
        /// </summary>
        public void CheckDressesLink()
        {
            DressesLnk.Click();
            Assert.That(DressesArg.Displayed, Is.True);
        }

    }
}
