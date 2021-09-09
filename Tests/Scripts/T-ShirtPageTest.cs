using NUnit.Framework;
using SeleniumShopTest.PageObjects.Pages;
using SeleniumShopTest.StartDriver;
using System;

namespace SeleniumShopTest.Tests.Scripts
{
    class TShirtPageTest : Initialize
    {
        [TestCaseSource(typeof(Initialize), "BrowserToRunWith")]
        [Test, Category("Smoke testing")]
        public void TShirtLink(String browserName)
        {
            Start(browserName);

            TShirtPage shirt = new TShirtPage();
           
            shirt.CheckTShirtLink();
        }
    }
}

