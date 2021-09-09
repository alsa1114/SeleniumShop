using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumShopTest.StartDriver;

namespace SeleniumShopTest.PageObjects.Pages
{
    public class WomenPage:Initialize
    {
        /// <summary>
        /// Add product to the cart locators
        /// </summary>
        private IWebElement LnkWomen => driver.FindElement(By.LinkText("Women"));
        private IWebElement IconList => driver.FindElement(By.CssSelector("i.icon-th-list"));
        private IWebElement BtnAddToCart => driver.FindElement(By.XPath("//span[text() ='Add to cart']"));
       
        /// <summary>
        /// Add product to cart logics
        /// </summary>
        public void ClickWomenLink()
      {
          Actions actions = new Actions(driver);

          LnkWomen.Click();

          actions.MoveToElement(IconList);
          
          IconList.Click();
          
          actions.MoveToElement(BtnAddToCart);

          BtnAddToCart.Click();
        
        }

        /// <summary>
        /// Posability to click women page
        /// </summary>
        public void CheckWomenLink()
        {
            LnkWomen.Click();
            Assert.That(LnkWomen.Displayed, Is.True);
        }
    }
}
