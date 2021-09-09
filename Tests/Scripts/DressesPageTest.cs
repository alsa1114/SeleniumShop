using NUnit.Framework;
using SeleniumShopTest.PageObjects.Pages;
using SeleniumShopTest.StartDriver;
using System;

namespace SeleniumShopTest.Tests.Scripts
{
    public class DressesPageTest: Initialize
    {

        [TestCaseSource(typeof(Initialize), "BrowserToRunWith")]
        [Test, Category("Smoke testing")]
        public void CheckDressesLink(String browserName)
        {
            Start(browserName);
            
            DressesPage dressesPage = new DressesPage();

            dressesPage.CheckDressesLink();
        
        }

    }
}
