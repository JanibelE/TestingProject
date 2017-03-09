using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ContactPagePluralSight
{
    public class Browser
    {
        static IWebDriver driver = new ChromeDriver(@"C://Drivers");

        public static ISearchContext Driver
        {
            get
            {
                return driver;
            }
        }

        public static void go_to(String url)
        {
            driver.Manage().Window.Maximize();
            driver.Url = url;
        }

        public static void close()
        {
            driver.Close();
        }

    }
}
