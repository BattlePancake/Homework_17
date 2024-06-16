using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_17.Factory;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_17.Pages
{
    internal class SortTablePage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
        }

        public string elementOne = "Smith";
        public string elementTwo = "$100.00";
        public string elementThree = "Tim";
        public string elementFour = "http://www.jsmith.com";

        public IWebElement ElementOne = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table1']//tr[1]//td[1]")));
        public IWebElement ElementTwo = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table1']//tr[3]//td[4]")));
        public IWebElement ElementThree = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[4]//td[2]")));
        public IWebElement ElementFour = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[1]//td[5]")));
    }
}