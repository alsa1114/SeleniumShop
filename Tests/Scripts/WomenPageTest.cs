using AventStack.ExtentReports;
using NUnit.Framework;
using SeleniumShopTest.PageObjects.Pages;
using System;
using SeleniumShopTest.StartDriver;

namespace SeleniumShopTest.Tests.Scripts
{
    /// <summary>
    /// AddItem to cart test
    /// </summary>
    [TestFixture]
    [Parallelizable]
    public class WomenPageTest:HomePageTest
    {
    
        [Test, Category("Smoke testing")]
        [TestCaseSource(typeof(Initialize), "BrowserToRunWith")]    
        public void AddItemToCart(String browserName)
        {
            Start(browserName);
            try
            {
                WomenPage women = new WomenPage();

                women.ClickWomenLink();

                test.Log(Status.Info, "Product was successfully added to the shopping cart");

                test.Log(Status.Pass, "AddItemToCart test PASSED");
            
            } catch (Exception e)
            
            {
                test.Log(Status.Fail, e.ToString());
                
                throw;
            }
            finally
            {
                if (driver!=null)
                {
                    driver.Quit();
                }
            }
        }
    }
}
