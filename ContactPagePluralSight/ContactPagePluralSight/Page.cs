using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ContactPagePluralSight
{
    public static class Page
    {

       public static HomePage HomePage
        {
            get
            {
                HomePage home = new HomePage();
                PageFactory.InitElements(Browser.Driver, home);
                return home;
            }
        }

    }

    public class HomePage
    {
        String url = "https://www.pluralsight.com/";
        public void GoTo()
        {
            Browser.go_to(url);
        }


      //  [FindsBy (How=How.ClassName, Using="plain")]
        //private IWebElement contact;
        public void Contact_Page()
        {
            IWebElement contact= Browser.Driver.FindElements(By.ClassName("plain"))[19];
            contact.Click();

        }
    }
}
