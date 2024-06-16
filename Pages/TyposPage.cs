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
    internal class TyposPage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");
        }

        public string referenceStringOne = "This example demonstrates a typo being introduced. It does it randomly on each page load.";
        public string referenceStringTwo = "Sometimes you'll see a typo, other times you won't.";

        public IWebElement StringOne = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='content']//p[1]")));
        public IWebElement StringTwo = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='content']//p[2]")));
    }
}
