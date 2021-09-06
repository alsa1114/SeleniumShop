using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using SeleniumShopTest.PageObjects.Pages;
using SeleniumShopTest.StartDriver;
using System;

namespace SeleniumShopTest
{
    [TestFixture]
    [Parallelizable]
    public class HomePageTest : Initialize
    {
       
        protected ExtentReports extent = null;
        protected ExtentTest test = null;

        /// <summary>
        /// ExtentReport creation
        /// </summary>
        [OneTimeSetUp]
        public void ExtentReportStart()
        {
           
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\ACER\source\repos\SeleniumShopTest\ExtentReports\SeleniumShopTest.html");
            extent.AttachReporter(htmlReporter);
        }
     

        [OneTimeTearDown]
        public void ExtentReportClose()
        {

            extent.Flush();
        }
        /// <summary>
        /// [SETUP] Browser init
        /// /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
           
            test = extent.CreateTest("Setup").Info("Test started");
            
            test.Log(Status.Info, "Browser launched");
        }

        /// <summary>
        /// Sign in check 
        /// </summary>
        [TestCaseSource(typeof(Initialize),"BrowserToRunWith")]
        [Test, Category("Smoke testing")]
        public void Login(String browserName)
        {
            Start(browserName);
            
            try {
               
                HomePage home = new HomePage();

                home.ClickSignIn();

                test.Log(Status.Info, "Login was link  Clicked");

                home.Autorization("alekseysamanchuk@gmail.com", "123abc");

                test.Log(Status.Info, "Username and password were entered");

                driver.Quit();

                test.Log(Status.Pass, "Login test PASSED");
            }
                catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());

                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
        /// <summary>
        /// Search test check
        /// </summary>
        [TestCaseSource(typeof(Initialize), "BrowserToRunWith")]
        [Test, Category("Smoke testing")]
        public void Search(String browserName)
        {
            Start(browserName);
            try
            {
               
                test.Log(Status.Info, "SearchTest was runned");

                HomePage search = new HomePage();

                search.ClickSearch("Summer Dress");

                test.Log(Status.Pass, "Search test PASSED");

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }

            finally

            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
    }
}