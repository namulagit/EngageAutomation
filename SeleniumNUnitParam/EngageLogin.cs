using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class EngageLogin : Hooks
    {


        [Test]
        public void LoginCheck()
        {
            Driver.Navigate().GoToUrl("http://loaduser1:Vanadium2200@beacon-test/sorce/");
            System.Threading.Thread.Sleep(5000);
            TimeSpan pageloadwait = TimeSpan.FromSeconds(30.00);
            Driver.Manage().Timeouts().ImplicitlyWait(pageloadwait);
            string title = Driver.Title;
            Assert.AreEqual("Homepage", title, "Page Title");
            System.Threading.Thread.Sleep(3000);
            Driver.Navigate().GoToUrl("http://Synverse%2ETest3:st%3A9872%40s@sorce-tfsbunker:8080/tfs/DefaultCollection/Beacon/Beacon%20Team/_build#definitionUri=&_a=completed");
            Driver.Manage().Timeouts().ImplicitlyWait(pageloadwait);
            string s = Driver.FindElement(By.XPath("(//*[contains(text(),'Engage Nightly_')])/preceding-sibling::div[1]")).GetCssValue("background-color");
            Driver.Close();
        }

    }
}
