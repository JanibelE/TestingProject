using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactPagePluralSight;

namespace TestExam
{
    [TestClass]
    public class Test
    {
        [TestInitialize]
        public void Go_To_HomePage()
        {
            Page.HomePage.GoTo();
        }

        [TestMethod]
        public void Go_To_Contact()
        {
            Page.HomePage.Contact_Page();
            ContactPage.form();
        }

       /* [TestCleanup]
        public void close()
        {
            Browser.close();
        }*/
    }
}
