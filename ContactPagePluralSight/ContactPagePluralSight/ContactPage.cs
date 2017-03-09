using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace ContactPagePluralSight
{
    public class ContactPage
    {
        static IWebElement Name = Browser.Driver.FindElement(By.Id("FirstName"));
        static IWebElement LastName = Browser.Driver.FindElement(By.Id("LastName"));
        static IWebElement Email = Browser.Driver.FindElement(By.Id("Email"));
        static IWebElement Company = Browser.Driver.FindElement(By.Id("Company"));
        static IWebElement phone = Browser.Driver.FindElement(By.Id("Phone"));
        static IWebElement msj = Browser.Driver.FindElement(By.Id("Message__c"));
        static IWebElement btn = Browser.Driver.FindElement(By.ClassName("mktoButton"));

        //Contact
        public static void form()
        {
            Name.SendKeys("Juan José");
            LastName.SendKeys("Peña");
            Email.SendKeys("Juan@gmail.com");
            Company.SendKeys("Orange Dominicana");
            Company.SendKeys(Keys.Enter);
            phone.SendKeys("(809)347-5254");
            new SelectElement(Browser.Driver.FindElement(By.Id("Country"))).SelectByValue("Dominican Republic");
            new SelectElement(Browser.Driver.FindElement(By.Id("Contact_Us_Form_Interest__c"))).SelectByValue("Individual");
            msj.SendKeys("Mensaje de prueba");
            //btn.Click();
        }
    }
}
