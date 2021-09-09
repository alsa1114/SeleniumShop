using OpenQA.Selenium;
using SeleniumShopTest.StartDriver;
namespace SeleniumShopTest.PageObjects.Pages
{ 
    public class HomePage : Initialize
    { 
        /// <summary>
        /// SignIn locators
        /// </summary>
        private IWebElement LnkLogIn => driver.FindElement(By.ClassName("login"));
        private IWebElement TxtEmail => driver.FindElement(By.Name("email"));
        private IWebElement TxtPass => driver.FindElement(By.Name("passwd"));
        private IWebElement BtnSubmit => driver.FindElement(By.Name("SubmitLogin"));

        /// <summary>
        /// Search input locators
        /// </summary>
        private IWebElement TxtSearch => driver.FindElement(By.Name("search_query"));
        private IWebElement BtnSearch => driver.FindElement(By.Name("submit_search"));

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

