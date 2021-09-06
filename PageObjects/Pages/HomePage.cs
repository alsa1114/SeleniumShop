using OpenQA.Selenium;
using SeleniumShopTest.StartDriver;
namespace SeleniumShopTest.PageObjects.Pages
{ 
    public class HomePage : Initialize
    { 
        /// <summary>
        /// SignIn locators
        /// </summary>
        public IWebElement LnkLogIn => driver.FindElement(By.ClassName("login"));
        public IWebElement TxtEmail => driver.FindElement(By.Name("email"));
        public IWebElement TxtPass => driver.FindElement(By.Name("passwd"));
        public IWebElement BtnSubmit => driver.FindElement(By.Name("SubmitLogin"));

        /// <summary>
        /// Search input locators
        /// </summary>
        public IWebElement TxtSearch => driver.FindElement(By.Name("search_query"));
        public IWebElement BtnSearch => driver.FindElement(By.Name("submit_search"));

        /// <summary>
        /// Autorization logics
        /// </summary>
        public void ClickSignIn() => LnkLogIn.Click();
        
        public void Autorization(string email, string password)
        {
            TxtEmail.SendKeys(email);

            TxtPass.SendKeys(password);
            
            BtnSubmit.Submit();
        }

        /// <summary>
        /// Search logics
        /// </summary>
        /// <param name="search"></param>
        public void ClickSearch(string search)
        {
            TxtSearch.SendKeys(search);

            BtnSearch.Submit();

        }
    }
}

