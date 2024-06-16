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
    internal class AddRemovePage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");
        }

        public void AddElement() => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Add Element']"))).Click();
        public void DeleteElement() => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Delete']"))).Click();

        public bool IsFirstElementVisible() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='elements']/button[1]"))).Displayed;
        public bool IsSecondElementVisible() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='elements']/button[2]"))).Displayed;
    }
}
