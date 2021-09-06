using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace SeleniumShopTest.StartDriver
{
    public class Initialize
    {
        public static IWebDriver driver = null;

        /// <summary>
        /// Browser launch
        /// </summary>
        public static void Start(String browserName)

        {

            if (driver == null && browserName.ToLower().Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else

                if (driver == null && browserName.ToLower().Equals("firefox"))

            {
                driver = new FirefoxDriver();

            }
            else
                throw new NotImplementedException();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://automationpractice.com/");

        }



        /// <summary>
        /// Browser quit
        /// </summary>
        /*[TearDown]
         public void CleanUp()
          {
             driver.Quit();
          }*/


        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "chrome", "firefox" };

            foreach (String b in browsers)
            {
                yield return b;
            }

        }
    }
}