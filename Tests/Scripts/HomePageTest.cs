using NUnit.Framework;
using SeleniumShopTest.PageObjects.Pages;
using SeleniumShopTest.StartDriver;
using System;

namespace SeleniumShopTest
{
    [TestFixture]
    public class HomePageTest : Initialize
    {
        [TestCaseSource(typeof(Initialize), "BrowserToRunWith")]
        [Test, Category("Smoke testing")]

        public void Login(String browserName)

        {
            Start(browserName);
           
            HomePage home = new HomePage();

            home.ClickSignIn();

            //  test.Log(Status.Info, "Login was link  Clicked");

            home.Autorization("alekseysamanchuk@gmail.com", "123abc");

            //   test.Log(Status.Info, "Username and password were entered");

            CleanUp();

            //  test.Log(Status.Pass, "Login test PASSED");
        }


        //  test.Log(Status.Fail, e.ToString());


        //}
        /*finally
        {
            if (driver != null)
            {
                CleanUp();
            }
        }*/

        /// <summary>
        /// Search test check
        /// </summary>

        [TestCaseSource(typeof(Initialize), "BrowserToRunWith")]
        [Test, Category("Smoke testing")]
        public void Search(String browserName)
        {
            Start(browserName);
            HomePage search = new HomePage();

            search.ClickSearch("Summer Dress");
        }
    }
}
              //  test.Log(Status.Pass, "Search test PASSED");
           // }
            //catch (Exception e)
            //{
               // test.Log(Status.Fail, e.ToString());
               // throw;
          //  }
            //finally
           // {
                //if (driver != null)
          
   // }
//
