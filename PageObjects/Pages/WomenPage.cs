using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumShopTest.StartDriver;

namespace SeleniumShopTest.PageObjects.Pages
{
    public class WomenPage:Initialize
    {
        /// <summary>
        /// Add product to the cart locators
        /// </summary>
        public IWebElement LnkWomen => driver.FindElement(By.LinkText("Women"));
        public IWebElement IconList => driver.FindElement(By.CssSelector("i.icon-th-list"));
        public IWebElement BtnAddToCart => driver.FindElement(By.XPath("//span[text() ='Add to cart']"));
       
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
    }
}
