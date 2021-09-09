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

        private IWebElement DressesLnk => driver.FindElement(By.ClassName("sf-with-ul"));
        private IWebElement DressesArg => driver.FindElement(By.CssSelector("span.cat-name"));


        public void CheckDressesLink()
        {
            DressesLnk.Click();
            Assert.That(DressesArg.Displayed, Is.True);
        }

    }
}
